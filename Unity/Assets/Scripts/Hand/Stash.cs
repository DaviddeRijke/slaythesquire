using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using Utils;

namespace DefaultNamespace.Hand
{
    [RequireComponent(typeof(DropZone))]
    public class Stash : MonoBehaviour
    {
        private DropZone _dropZone;
        private List<Card> CardsInStash;
        
        public CardEvent OnCardReceived = new CardEvent();

        private void Awake()
        {
            CardsInStash = new List<Card>();
            _dropZone = GetComponent<DropZone>();
            _dropZone.OnDrop.AddListener(AddCard);
        }

        public List<Card> Reset()
        {
            Card[] ret = new Card[CardsInStash.Capacity];
            CardsInStash.CopyTo(ret);
            Debug.Log(CardsInStash.Count);
            CardsInStash.Clear();
            return ret.ToList();
        }

        private void AddCard(Card c)
        {
            if (IsValidOperation(c))
            {
                CardsInStash.Add(c);
                Debug.Log("Added to stash (" + CardsInStash.Count);
                OnCardReceived.Invoke(c);
            }
        }

        private bool IsValidOperation(Card card)
        {
            //check for game state, rules, etc...
            return true;
        }
    }
}