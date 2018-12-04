using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public class Resolver : MonoBehaviour
    {
        public SocketService SocketService;
        
        private List<Card> _own;
        private List<Card> _other;
        private List<Effect> _effects;
        
        public Knight OwnKnight;
        public Knight OtherKnight;

        public void Awake()
        {
        }

        private void Start()
        {
            SocketService.OnOpponentCardPlayed.AddListener(OpponentPlayedCard);
        }

        /// <summary>
        /// This method will be refactored as it does not belong here. It is put here for the sake of debugging
        /// </summary>
        public void OpponentPlayedCard()
        {
        }

        public void Resolve()
        {
            for (int i = 0; i < Mathf.Max(_own.Count, _other.Count); i++)
            {
                var ownCard = i < _own.Count ? _own[i] : null;
                var otherCard = i < _other.Count ? _other[i] : null;
                ResolveCards(ownCard, otherCard);
            }
            //Send status (preferably through event)
            //Animator should send status too!
        }

        private void ResolveCards(Card ownCard, Card otherCard)
        {
            var forAnimator = ownCard.effects.ToList().ToSortedQueue(otherCard.effects.ToList(), OwnKnight, OtherKnight);          
        }


        //Hand.OnPlay invokes SocketService.PlayCard
        //xxxx listens to (void)SocketService.OpponentPlaysCard
        //EndTurn invokes SocketService.EndTurn(list<Card>)
        //EndTurn adds list<card> to Resolver
        //Resolver listens to (List<Card>)SocketService.EndTurn
        //Resolver resolves cards
        //Resolver invokes SocketService.SendStatus(status)

    }
}