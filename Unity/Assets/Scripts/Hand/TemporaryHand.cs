using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using Utils;

namespace DefaultNamespace.Hand
{
    public class TemporaryHand : MonoBehaviour
    {
        public List<Card> CardsInHand;
        public IngameDeck Deck;
        public Stash Stash;
        public PlayField PlayField;

        public CardEvent OnDraw = new CardEvent();
        public CardEvent OnDiscard = new CardEvent();
        public CardEvent OnPlay = new CardEvent();

        private int capacity
        {
            get { return GameRules.AmountOfCardsInHand - CardsInHand.Count; }
        }

        public void Awake()
        {
            CardsInHand = new List<Card>();
        }

        public void Start()
        {
            Stash.OnCardReceived.AddListener(Discard);
            PlayField.OnCardReceived.AddListener(Play);
            Deck.OnRequestShuffle.AddListener(Shuffle);
            Draw(GameRules.AmountOfStartingCards);
        }

        private void Shuffle(int remainder)
        {
            var cardsLeft = Stash.Reset();
            if (cardsLeft.Count == 0) return;
            Deck.Shuffle(cardsLeft);
            Draw(remainder);
        }

        private void Discard(Card card)
        {
            if (!CardsInHand.Contains(card))
            {
                return;
            }     
            CardsInHand.Remove(card);
            OnDiscard.Invoke(card);        
        }

        private void Play(Card card)
        {
            CardsInHand.Remove(card);
            OnPlay.Invoke(card);
        }

        public void Draw(int amount)
        {
            if (capacity <= 0) return;
            var cardsDrawn = Deck.DrawCards(amount);
            CardsInHand.AddRange(cardsDrawn);
            foreach (var card in cardsDrawn)
            {
                OnDraw.Invoke(card);
            }            
        }

        public void Fill()
        {
            Draw(capacity);
        }
    }
}