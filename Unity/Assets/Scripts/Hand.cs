using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

    private List<GameObject> cards;
    public float spacing = 0.6f;
    public float distance = -0.03f;
    public float totalTwist = 20f;
    public float nudgeDown = 0.01f;

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

        float startTwist = 1f * (totalTwist / 2f);
        float twistPerCard = totalTwist / cards.Count;

        for (int i = 0; i < cards.Count; i++)
        {
            Transform card = cards[i].transform;

            float twist = startTwist - (i * twistPerCard);

            card.rotation = transform.rotation;
            card.Rotate(0f, 0f, twist);

            card.localPosition = new Vector3(transform.position.x - (spacing * cards.Count * 0.5f - spacing * 0.5f), 0f, 0f);
            card.localPosition += new Vector3(i * spacing, -Mathf.Abs(twist * nudgeDown), distance * i);           
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
