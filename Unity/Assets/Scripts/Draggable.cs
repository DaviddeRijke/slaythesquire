using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Card))]
public class Draggable : MonoBehaviour {

    private Transform card;
    private Vector3 dragOffset;
    private Plane plane;

    void OnMouseDown()
    {
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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float dist;
        plane.Raycast(ray, out dist);
        Vector3 v3Pos = ray.GetPoint(dist);
        card.position = v3Pos + dragOffset;
    }

    void OnMouseUp()
    {
        GetComponent<BoxCollider>().enabled = false;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            DropZone dropZone = hit.transform.GetComponent<DropZone>();
            if (dropZone != null)
            {
                // Card is played
                dropZone.DropCard(GetComponent<Card>());
                Debug.Log("Card is played!");
            }
        }

        GetComponent<BoxCollider>().enabled = true;
    }
}
