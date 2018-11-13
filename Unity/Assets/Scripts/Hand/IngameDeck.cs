using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityScript.Lang;
using Utils;

public class IngameDeck : MonoBehaviour
{
    private Deck deck;
    private Queue<Card> cardsInDeck;
    public IntEvent OnRequestShuffle = new IntEvent();

    public void Init(Deck deck)
    {
        this.deck = deck;
        cardsInDeck = deck.Cards.Shuffle().ToQueue();
    }

    public void Shuffle(List<Card> cards)
    {
        Debug.Log("Shuffle");
        Debug.Log(cards.Count);
        var shuffled = cards.ToArray().Shuffle();
        foreach (var card in shuffled)
        {
            cardsInDeck.Enqueue(card);
        }
        Debug.Log(cardsInDeck.Count);
    }

    public Card[] DrawCards(int amount)
    {
        int actualAmount = Mathf.Min(amount, cardsInDeck.Count);
        if (actualAmount != amount)
        {
            OnRequestShuffle.Invoke(amount - actualAmount);
        }
        Card[] cardsDrawn = new Card[actualAmount];
        Debug.Log(actualAmount);
        for (var i = 0; i < actualAmount; i++)
        {
            Debug.Log(cardsInDeck.Count);
            cardsDrawn[i] = cardsInDeck.Dequeue();
        }
        return cardsDrawn;
    }   
}