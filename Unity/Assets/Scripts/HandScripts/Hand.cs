using System.Collections.Generic;
using DefaultNamespace;
using DefaultNamespace.Hand;
using UnityEngine;
using Utils;

namespace HandScripts
{
    public class Hand : MonoBehaviour
    {
        //Use this to communicate with the server
        private GameCommunicator GameCommunicator;

        //This is not a list to the gameobjects, but to the script instances! Thus this are the objects you want to work with, if it's not for UI.
        public List<Card> CardsInHand;
        
        //Each of these is associated with a dropzone script
        public IngameDeck Deck;
        public Stash Stash;
        public PlayField PlayField;

        /// <summary>
        /// NOTE: These events are meant for the UI. They are triggered only after everything has been handled,
        /// and thus they should not have any listeners within the game logic.
        /// </summary>
        public CardEvent OnDraw = new CardEvent();
        public CardEvent OnDiscard = new CardEvent();
        public CardEvent OnPlay = new CardEvent();

        /// <summary>
        /// Returns the amount of cards that can still be added to the hand. Value is defined in the static GameRules class.
        /// </summary>
        private int Capacity
        {
            get { return GameRules.AmountOfCardsInHand - CardsInHand.Count; }
        }

        public void Awake()
        {
            
            CardsInHand = new List<Card>();
            
            Stash.OnCardReceived.AddListener(Discard);
            PlayField.OnCardReceived.AddListener(Play);
            Deck.OnRequestShuffle.AddListener(Shuffle);

            //TEST
            GameCommunicator = DDOLAccesser.GetObject().GetComponent<GameCommunicator>();
        }

        public void Start()
        {
            OnPlay.AddListener(GameCommunicator.PlayCard);
            
            //makes sure the game is started with the amount of cards specified in the static GameRules class
            Draw(GameRules.AmountOfStartingCards);
        }

        /// <summary>
        /// Shuffles all cards in the deck, and draws the remaining cards of the previous draw operation
        /// </summary>
        /// <param name="remainder">The amount of cards not drawn after previous draw operation</param>
        private void Shuffle(int remainder)
        {
            var cardsLeft = Stash.Reset();
            if (cardsLeft.Count == 0) return;
            Deck.Shuffle(cardsLeft);
            Draw(remainder);
        }

        /// <summary>
        /// Called when the Stash receives cards, to make sure said card is also removed here.
        /// OnDiscard is still invoked to fix the UI.
        /// </summary>
        /// <param name="card">The card to be discarded, automatically passed after the drop</param>
        private void Discard(Card card)
        {
            if (!CardsInHand.Contains(card))
            {
                return;
            }     
            CardsInHand.Remove(card);
            OnDiscard.Invoke(card);        
        }

        /// <summary>
        /// Called when the PlayField receives cards, to make sure said card is also removed here.
        /// OnPlay is still invoked to fix the UI.
        /// </summary>
        /// <param name="card">The card to be played, automatically passed after the drop</param>
        private void Play(Card card)
        {
            CardsInHand.Remove(card);
            OnPlay.Invoke(card);
        }

        /// <summary>
        /// Called when needing to draw cards.
        /// When not enough cards are available in the deck, the deck will request an reshuffle,
        /// after which a new Draw is initiated with as amount the amount of cards not yet drawn.
        /// This method does not have to handle that.
        /// </summary>
        /// <param name="amount"></param>
        public void Draw(int amount)
        {
            if (Capacity <= 0) return;
            var cardsDrawn = Deck.DrawCards(amount);
            CardsInHand.AddRange(cardsDrawn);
            foreach (var card in cardsDrawn)
            {
                OnDraw.Invoke(card);
            }            
        }

		public void DrawForEnergy(int amount)
		{
			if (Capacity <= 0) return;
			if (PlayField.self.energy >= 1)
			{
				Draw(amount);
				PlayField.self.RemoveEnergy(1);
			}
			else
			{
				Debug.Log("Out of energy, can't draw card!");
			}
		}

        /// <summary>
        /// Draws the maximum amount of cards that still fit in the hand.
        /// </summary>
        public void Fill()
        {
            Draw(Capacity);
        }
    }
}