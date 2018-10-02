using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Card))]
public class Draggable : MonoBehaviour {

    private Hand hand;
    private Transform card;
    private Vector3 dragOffset;
    private Plane plane;

    void Start()
    {
        hand = GetComponentInParent<Hand>();
    }

    void OnMouseDown()
    {
        if (!GameManager._instance.CanPlay)
            return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            card = hit.transform;
            plane.SetNormalAndPosition(Camera.main.transform.forward, card.position);
            float dist;
            plane.Raycast(ray, out dist);
            dragOffset = card.position - ray.GetPoint(dist);
        }
    }

    void OnMouseDrag()
    {
        if (!GameManager._instance.CanPlay)
            return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float dist;
        plane.Raycast(ray, out dist);
        Vector3 v3Pos = ray.GetPoint(dist);
        card.position = v3Pos + dragOffset;
    }

    void OnMouseUp()
    {
        if (!GameManager._instance.CanPlay)
            return;

        GetComponent<BoxCollider>().enabled = false;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            DropZone dropZone = hit.transform.GetComponent<DropZone>();
            if (dropZone != null)
            {
                // Card is played
                //hand.RemoveCard(gameObject); Enable this again later
                dropZone.DropCard(GetComponent<Card>());
                Debug.Log("Card is played!");
            }
        }
        else
        {
            hand.FitCards();
        }

        GetComponent<BoxCollider>().enabled = true;
    }
}
