using System.Collections.Generic;
using Turns;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{

    public CardContainer CardContainer;
    public GameObject Card2DPrefab;
    public Transform Container;
    void OnEnable()
    {
        if (CardContainer.Cards == null) return;
        foreach (Transform child in Container)
        {
            Destroy(child.gameObject);
        }
        foreach (Card card in CardContainer.Cards)
        {
            var obj = Instantiate(Card2DPrefab);
            obj.transform.SetParent(Container, false);
            var view2d = obj.GetComponent<CardView2D>();
            view2d.initCard(card);
        }
    }
}
