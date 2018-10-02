using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

    private List<GameObject> cards;
    public float spacing = 0.6f;
    public float distance = 0.03f;

	// Use this for initialization
	void Start () {
        cards = new List<GameObject>();
        UpdateList();
        FitCards();
	}

    private void UpdateList()
    {
        cards.Clear();
        foreach (Transform t in transform)
        {
            GameObject card = t.gameObject;
            if (card.GetComponent<Draggable>() != null)
            {
                cards.Add(card);
            }
        }
    }

	public void FitCards() {
        if (cards.Count == 0)
            return;

        for (int i = 0; i < cards.Count; i++)
        {
            Transform card = cards[i].transform;

            card.localPosition = new Vector3(transform.position.x - (spacing * cards.Count * 0.5f - spacing * 0.5f), 0f, 0f);
            card.localPosition += new Vector3(i * spacing, distance * i, 0f);
        }
	}

    public void AddCard(GameObject card)
    {
        cards.Add(card);
        card.transform.SetParent(transform);
        FitCards();
    }

    public void RemoveCard(GameObject card)
    {
        cards.Remove(card);
        card.transform.SetParent(null);
        FitCards();
    }
}
