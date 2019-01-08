using Resolve;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using UnityEngine;
using Utils;

namespace DefaultNamespace
{
    public class Resolver : MonoBehaviour
    {      
        private List<Card> _own;
        private List<Effect> _effects;
        
        public Knight OwnKnight;
        public Knight OtherKnight;

        private void Start()
        {
            //SocketService.Instance.OnOpponentCardPlayed.AddListener(OpponentPlayedCard);
            //SocketService.Instance.OnResolvePhase.AddListener(Resolve);
        }

        public void SetOwnCards(List<Card> cards)
        {
            _own = cards;
        }


        /// <summary>
        /// This method will be refactored as it does not belong here. It is put here for the sake of debugging
        /// </summary>
        public void OpponentPlayedCard()
        {
            Debug.Log("Resolver got OpponentPlayedCard");
        }

        public void Resolve(List<Card> other)
        {
            for (int i = 0; i < Mathf.Max(_own.Count, other.Count); i++)
            {
                var ownCard = i < _own.Count ? _own[i] : null;
                var otherCard = i < other.Count ? other[i] : null;
                ResolveCards(ownCard, otherCard);
            }
            //Send status (preferably through event)
            //Animator should send status too!
        }

        private void ResolveCards(Card ownCard, Card otherCard)
        {
            List<Effect> ownCardEffects = ownCard == null ? new List<Effect>() : ownCard.effects.ToList();
            List<Effect> otherCardEffects = otherCard == null ? new List<Effect>() : otherCard.effects.ToList();
            
            
            var forAnimator = ownCardEffects.ToSortedQueue(otherCardEffects, OwnKnight, OtherKnight);

            if (forAnimator == null) return;
            // ----(((((( cob = code execution block ))))))----
            for (int i = 0; i < forAnimator.Count; i++)
            {
                //Grab first effect and look at the second
                EffectData e1 = forAnimator.Dequeue();
                EffectData e2 = forAnimator.Peek();

                if (e1.Effect is INoInteraction) //Within cob 1
                {
                    e1.Effect.Activate(e1.Caster, GetOtherKnight(e1.Caster));
                    if (e2.Effect is INoInteraction && !e2.Caster.Equals(e1.Caster)) //Two can play at once
                    {
                        e2 = forAnimator.Dequeue();
                        e2.Effect.Activate(e2.Caster, GetOtherKnight(e2.Caster));
                        i++;
                    }
                }
                else if (e1.Effect is IBlock)
                {
                    if (e2.Effect is IBlockable && !e2.Caster.Equals(e1.Caster)) //Within cob 2 with block
                    {
                        StartCoroutine(PlayEffectAfterTime(e1, 1.5f));
                        e2 = forAnimator.Dequeue();
                        e2.Effect.Activate(e2.Caster, GetOtherKnight(e2.Caster));
                        i++;
                    }
                    else if (e2.Effect is IBlock && !e2.Caster.Equals(e1.Caster)) //Within cob 3 (Play two)
                    {
                        e1.Effect.Activate(e1.Caster, GetOtherKnight(e1.Caster));
                        e2 = forAnimator.Dequeue();
                        e2.Effect.Activate(e2.Caster, GetOtherKnight(e2.Caster));
                        i++;
                    }
                    else //Within cob 3 (Play one, because the next is from the same knight)
                    {
                        e1.Effect.Activate(e1.Caster, GetOtherKnight(e1.Caster));
                    }
                }
                else if (e1.Effect is IBlockable) //Within cob 2 without block
                {
                    e1.Effect.Activate(e1.Caster, GetOtherKnight(e1.Caster));
                }
            }
        }

        private Knight GetOtherKnight(Knight question)
        {
            if (question.Equals(OwnKnight))
            {
                return OtherKnight;
            }
            else if (question.Equals(OtherKnight))
            {
                return OwnKnight;
            }
            else
            {
                return null;
            }
        }

        private IEnumerator PlayEffectAfterTime(EffectData e, float delay)
        {
            yield return new WaitForSeconds(delay);
            e.Effect.Activate(e.Caster, GetOtherKnight(e.Caster));
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