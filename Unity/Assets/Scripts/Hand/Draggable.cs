using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CardView3D))]
public class Draggable : MonoBehaviour {

    private CardHolder holder;
    private Transform card;
    private Vector3 dragOffset;
    private Plane plane;

    void Start()
    {
        holder = GetComponentInParent<CardHolder>();
    }

    void OnMouseDown()
    {
        if (!GameManager._instance.AcceptCardInput)
            return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            card = hit.transform;
            card.rotation = new Quaternion(0f, 0f, 0f, 0f);
            plane.SetNormalAndPosition(Camera.main.transform.forward, card.position);
            float dist;
            plane.Raycast(ray, out dist);
            dragOffset = card.position - ray.GetPoint(dist);
        }
    }

    void OnMouseDrag()
    {
        if (!GameManager._instance.AcceptCardInput)
            return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float dist;
        plane.Raycast(ray, out dist);
        Vector3 v3Pos = ray.GetPoint(dist);
        card.position = v3Pos + dragOffset;
    }

    void OnMouseUp()
    {
        if (!GameManager._instance.AcceptCardInput)
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
                dropZone.DropCard(GetComponent<CardView3D>());
            }
        }
        holder.FitCards();

        GetComponent<BoxCollider>().enabled = true;
    }
}
