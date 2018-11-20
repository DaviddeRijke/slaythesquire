using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using Utils;

namespace DefaultNamespace.Hand
{
    /// <summary>
    /// Discard pile
    /// </summary>
    [RequireComponent(typeof(DropZone))]
    public class Stash : MonoBehaviour
    {
        private DropZone _dropZone;
        
        //The list of card instances (not the View3D's, as they are currently removed)
        private List<Card> CardsInStash;
        
        //This event will be listened to by the hand
        public CardEvent OnCardReceived = new CardEvent();

        private void Awake()
        {
            CardsInStash = new List<Card>();
            _dropZone = GetComponent<DropZone>();
            _dropZone.OnDrop.AddListener(AddCard);
        }

        /// <summary>
        /// Should return all cards, while clearing the list in this class
        /// Lemme check if this really worked, the .ToList() is a void, though it should return the list.
        /// </summary>
        /// <returns></returns>
        public List<Card> Reset()
        {
            Card[] ret = new Card[CardsInStash.Capacity];
            CardsInStash.CopyTo(ret);
            Debug.Log(CardsInStash.Count);
            CardsInStash.Clear();
            return ret.ToList();
            //TODO seems to be a bug
        }

        /// <summary>
        /// Adds a card to the Stash. This card is automatically passed after dropping it on the dropzone
        /// </summary>
        /// <param name="c">The card to be added to the discard pile</param>
        private void AddCard(Card c)
        {
            if (IsValidOperation(c))
            {
                CardsInStash.Add(c);
                Debug.Log("Added to stash (" + CardsInStash.Count);
                OnCardReceived.Invoke(c);
            }
        }

        /// <summary>
        /// Checks if card can be discarded
        /// (don't know why it should be, but inb4)
        /// This method should probably be moved to a class like DropZone, after which certain values for this method
        /// can be passed through the inspector. This method returns in PlayField.
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