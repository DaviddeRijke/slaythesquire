using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace DefaultNamespace.Hand
{   
    [RequireComponent(typeof(DropZone))]
    public class PlayField : MonoBehaviour
    {    
        private DropZone _dropZone;
        private List<Card> CardsInField;
    
        public CardEvent OnCardReceived = new CardEvent();

        private void Awake()
        {
            CardsInField = new List<Card>();
            _dropZone = GetComponent<DropZone>();
            _dropZone.OnDrop.AddListener(AddCard);
        }

        /// <summary>
        /// Adds a card to the playfield.
        /// Due to the current game design, i'm not sure of this immediately means the card is also played.
        /// At least, all cards will be placed in order this way.
        /// </summary>
        /// <param name="c"></param>
        private void AddCard(Card c)
        {
            if (IsValidOperation(c))
            {
                CardsInField.Add(c);
                OnCardReceived.Invoke(c);
            }
        }

        /// <summary>
        /// Checks if card can be played
        /// (don't know why it should be, but inb4)
        /// This method should probably be moved to a class like DropZone, after which certain values for this method
        /// can be passed through the inspector. This method returns in Stash.
        /// </summary>
        /// <param name="card">The card to be checked</param>
        /// <returns>boolean whether card will be accepted or not</returns>
        private bool IsValidOperation(Card card)
        {
            //check for game state, rules, etc...
            return true;
        }
        
    }
}