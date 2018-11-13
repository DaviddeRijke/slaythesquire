using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IngameDeck : MonoBehaviour
{
        private Deck deck;
        private Queue<Card> cardsInDeck;
        public UnityEvent OnRequestShuffle;

        public void Init(Deck deck)
        {
            this.deck = deck;
            
            //Orders the cards in this deck
            cardsInDeck = deck.Cards.Shuffle().ToQueue();
        }

    public Card[] DrawCards(int amount)
    {
        if (amount >= cardsInDeck.Count)
        {
            OnRequestShuffle.Invoke();
        }
        Card[] cardsDrawn = new Card[amount];
        for (var i = 0; i < amount; i++)
        {
            cardsDrawn[i] = cardsInDeck.Dequeue();
        }
        return cardsDrawn;
    }   
}