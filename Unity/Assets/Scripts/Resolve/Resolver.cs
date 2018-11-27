using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public class Resolver : MonoBehaviour
    {
        private List<Card> _own;
        private List<Card> _other;
        private List<Effect> _effects;
        

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
            foreach (var effect in ownCard.effects)
            {
                effect.Activate(otherCard.effects);
            }

            foreach (var effect in otherCard.effects)
            {
                effect.Activate(ownCard.effects);
            }

            ownCard.effects.ToList().ToSortedQueue(otherCard.effects.ToList());

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