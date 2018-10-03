using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

    private List<GameObject> cards;

    // Use this for initialization
    void Start () {
        cards = new List<GameObject>();
	}

    public void AddCard(GameObject card)
    {
        cards.Add(card);
        card.transform.SetParent(transform);
    }

    public void RemoveCard(GameObject card)
    {
        cards.Remove(card);
        card.transform.SetParent(null);
    }
}
