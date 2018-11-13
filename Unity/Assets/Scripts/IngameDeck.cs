using System.Collections.Generic;
using UnityEngine;

public class IngameDeck : MonoBehaviour
{
        private Deck deck;
        private Queue<Card> cardsInDeck;

        public void Init(Deck deck)
        {
            this.deck = deck;
            cardsInDeck = deck.Cards.Shuffle();
        }

}