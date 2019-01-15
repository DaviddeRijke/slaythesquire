using Resolve;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting;
using UnityEditor;
using UnityEngine;
using Utils;

namespace DefaultNamespace
{
    public class Resolver : MonoBehaviour
    {
        private GameCommunicator gameCommunicator;
        private StatusEvent OnResolved = new StatusEvent();

        private List<Card> _own;
        private List<Card> _other;
        
        public Knight OwnKnight;
        public Knight OtherKnight;

        private void Start()
        {
            gameCommunicator = DDOLAccesser.GetObject().GetComponent<GameCommunicator>();
            gameCommunicator.OnOpponentCardPlayed.AddListener(OpponentPlayedCard);
            gameCommunicator.OnResolvePhase.AddListener(SetResolveStatus);
            OnResolved.AddListener(gameCommunicator.SendStatus);
        }

        public void SetOwnCards(List<Card> cards)
        {
            _own = cards;
        }

        private bool _startResolve;
        private void SetResolveStatus(List<Card> cards)
        {
            Debug.Log("Resolve status has been set. Own: " + _own.Count + ", other: " + cards.Count);
            _other = cards;
            _startResolve = true;
        }

        /// <summary>
        /// This method will be refactored as it does not belong here. It is put here for the sake of debugging
        /// </summary>
        public void OpponentPlayedCard()
        {
            Debug.Log("Resolver got OpponentPlayedCard");
        }

        
        private void Update()
        {
            if (_startResolve)
            {
                _startResolve = false;
                StartCoroutine(ResolveAllPlayedCards());
            }
        }

        /// <summary>
        /// NOTE: The Cards are NOT sorted yet. This happens per card, not per list of cards.
        /// </summary>
        /// <returns></returns>
        private IEnumerator ResolveAllPlayedCards()
        {
            print("start resolve: " + Time.time );
            for (int i = 0; i < Mathf.Max(_own.Count, _other.Count); ++i)
            {
                var ownCard = i < _own.Count ? _own[i] : null;
                var otherCard = i < _other.Count ? _other[i] : null;
                if(ownCard != null && otherCard != null) print(ownCard.effects.Length + " + " + otherCard.effects.Length + " effects that must be sorted");
                var currentEffects = GetEffectsForCurrentCards(ownCard, otherCard);
                print(currentEffects.Count + " effects will be resolved");
                yield return StartCoroutine(ResolveCurrentCards(currentEffects));
            }
            print("invoking onresolved: " + Time.time );
            OnResolved.Invoke("get status", CheckForWinner());
        }

        private Queue<EffectData> GetEffectsForCurrentCards(Card ownCard, Card otherCard)
        {
            List<Effect> ownCardEffects = ownCard == null ? new List<Effect>() : ownCard.effects.ToList();
            List<Effect> otherCardEffects = otherCard == null ? new List<Effect>() : otherCard.effects.ToList();        
           return ownCardEffects.ToSortedQueue(otherCardEffects, OwnKnight, OtherKnight);
        }

        private IEnumerator ResolveCurrentCards(Queue<EffectData> effects)
        {
            for (int i = 0; i < effects.Count; ++i)
            {
                //Dequeue the next effect
                EffectData e1 = effects.Dequeue();
                //Check if there are more effects
                bool isLast = effects.Count <= 0;              
                //If there are more effects, look what kind of effect
                EffectData e2 = isLast ? new EffectData() : effects.Peek();
                
                //if e2 is enemy NoInteraction, perform both. Otherwise, only self.
                if (e1.Effect is INoInteraction)
                {   
                    //If e2 is also a no interaction
                    if (!isLast && e2.Effect is INoInteraction && !e2.Caster == e1.Caster)
                    {
                        ++i;
                        yield return StartCoroutine(Activate(e1, effects.Dequeue()));
                    }
                    else
                    {
                        yield return StartCoroutine(Activate(e1));
                    }
                 }

                //if e2 is enemy blockable, block the attack. If e2 is enemy block, both block
                else if (e1.Effect is IBlock)
                {
                    //if e2 is bl
                    if (!isLast && !e2.Caster.Equals(e1.Caster)) //Within cob 2 with block
                    {
                        if (e2.Effect is IBlockable)
                        {
                            ++i;
                            yield return StartCoroutine(ActivateBlockedAttack(e1, effects.Dequeue()));
                        }
                        else if (e2.Effect is IBlock)
                        {
                            ++i;
                            yield return StartCoroutine(Activate(e1, effects.Dequeue()));
                        }
                        else yield return StartCoroutine(Activate(e1));
                    }
                    else
                    {
                        yield return StartCoroutine(Activate(e1));
                    }
                }
                //all blocks should be handled, so this attack can't be blocked. Therefore it can be executed without taking e2 into account
                else if (e1.Effect is IBlockable)
                {
                    yield return StartCoroutine(Activate(e1));
                }

            }
        }

        private IEnumerator ActivateBlockedAttack(EffectData defender, EffectData attacker)
        {
            print("Activate called for: defender:" + defender.Effect.name + ", attacker: " + attacker.Effect.name);
            attacker.Effect.Activate(attacker.Caster, GetOtherKnight(attacker.Caster));
            yield return new WaitForSeconds(attacker.Effect.Duration() - defender.Effect.Duration());
            defender.Effect.Activate(defender.Caster, GetOtherKnight(defender.Caster));
            yield return new WaitForSeconds(defender.Effect.Duration());
        }

        private IEnumerator Activate(EffectData e)
        {
            print("Activate called for: " + e.Effect.name);
            e.Effect.Activate(e.Caster, GetOtherKnight(e.Caster));
            yield return new WaitForSeconds(e.Effect.Duration());
        }

        private IEnumerator Activate(EffectData e1, EffectData e2)
        {
            print("Activate called for: " + e1.Effect.name + ", " + e2.Effect.name);
            e1.Effect.Activate(e1.Caster, GetOtherKnight(e1.Caster));
            e2.Effect.Activate(e2.Caster, GetOtherKnight(e2.Caster));
            yield return new WaitForSeconds(Mathf.Max(e1.Effect.Duration(), e2.Effect.Duration()));
        }


        private Knight GetOtherKnight(Knight question)
        {
            if (question.Equals(OwnKnight))
            {
                return OtherKnight;
            }
            if (question.Equals(OtherKnight))
            {
                return OwnKnight;
            }
            return null;
        }

        private int CheckForWinner()
        {
            if (OwnKnight.health <= 0)
            {
                return gameCommunicator.OpponentPlayerId;
            }
            if (OtherKnight.health <= 0)
            {
                return gameCommunicator.OwnPlayerId;
            }

            return 0;
        }

    }
}