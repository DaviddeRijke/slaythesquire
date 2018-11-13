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

        private void AddCard(Card c)
        {
            if (IsValidOperation(c))
            {
                CardsInField.Add(c);
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