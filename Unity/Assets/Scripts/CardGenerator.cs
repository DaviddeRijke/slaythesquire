using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Events;

public class CardGenerator : MonoBehaviour
{

    public CardContainer CardContainer;
    public GameObject Card2DPrefab;
    public Transform Container;
    public static readonly CardListEvent OnCardsGenerated = new CardListEvent();
    
    void OnEnable()
    {
     GenerateCards();  
    }

    void GenerateCards()
    { if (CardContainer.Cards == null) return;
        var cardViews = new List<CardView2D>();
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
            cardViews.Add(view2d);
        }
        OnCardsGenerated.Invoke(cardViews);
    }
}
