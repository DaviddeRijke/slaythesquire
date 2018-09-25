using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTest : MonoBehaviour {

    private Transform card;
    private Vector3 dragOffset;
    private Plane plane;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        Debug.Log("Mouse is Down!");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            // TODO: check if Transform is a card
            card = hit.transform;
            plane.SetNormalAndPosition(Camera.main.transform.forward, card.position);
            float dist;
            plane.Raycast(ray, out dist);
            dragOffset = card.position - ray.GetPoint(dist);
            Debug.Log("Got Card!");
        }
    }

    void OnMouseDrag()
    {
        Debug.Log("Mouse is being Dragged!");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float dist;
        plane.Raycast(ray, out dist);
        Vector3 v3Pos = ray.GetPoint(dist);
        card.position = v3Pos + dragOffset;
    }
}
