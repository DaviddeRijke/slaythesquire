using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

    private List<GameObject> cards; 

	// Use this for initialization
	void Start () {
        foreach (Transform t in transform)
        {
            GameObject card = t.gameObject;
            if (card.GetComponent<Draggable>() != null)
            {
                cards.Add(card);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
