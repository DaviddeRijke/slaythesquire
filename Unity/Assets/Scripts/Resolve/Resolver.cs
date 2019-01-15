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
        private List<Effect> _effects;
        
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
                StartCoroutine(ResolveInQueue());
            }
        }

        /// <summary>
        /// NOTE: The Cards are NOT sorted yet. This happens per card, not per list of cards.
        /// </summary>
        /// <returns></returns>
        private IEnumerator ResolveInQueue()
        {
            for (int i = 0; i < Mathf.Max(_own.Count, _other.Count); i++)
            {
                var ownCard = i < _own.Count ? _own[i] : null;
                var otherCard = i < _other.Count ? _other[i] : null;
                yield return StartCoroutine(AnotherResolve(GetEffects(ownCard, otherCard)));
            }
            OnResolved.Invoke("get status", 0);
        }

        private Queue<EffectData> GetEffects(Card ownCard, Card otherCard)
        {
            List<Effect> ownCardEffects = ownCard == null ? new List<Effect>() : ownCard.effects.ToList();
            List<Effect> otherCardEffects = otherCard == null ? new List<Effect>() : otherCard.effects.ToList();                       
           return ownCardEffects.ToSortedQueue(otherCardEffects, OwnKnight, OtherKnight);
        }

        private IEnumerator AnotherResolve(Queue<EffectData> effects)
        {                    
            for (int i = 0; i < effects.Count; i++)
            {
                //Debug.Log("Looping forAnimator...");
                //Grab first effect and look at the second
                EffectData e1 = effects.Dequeue();
                bool isLast = effects.Count <= 0;
                EffectData e2 = isLast ? new EffectData() : effects.Peek();

                if (e1.Effect is INoInteraction) //Within cob 1
                {
                    yield return StartCoroutine(Activate(e1));
                    if (!isLast && e2.Effect is INoInteraction && !e2.Caster.Equals(e1.Caster)) //Two can play at once
                    {
                        yield return StartCoroutine(Activate(effects.Dequeue()));
                        i++;
                    }
                }
                else if (e1.Effect is IBlock)
                {
                    if (!isLast && e2.Effect is IBlockable && !e2.Caster.Equals(e1.Caster)) //Within cob 2 with block
                    {
                        yield return StartCoroutine(Activate(e1));
                        yield return StartCoroutine(Activate(effects.Dequeue()));
                        i++;
                    }
                    else if (!isLast && e2.Effect is IBlock && !e2.Caster.Equals(e1.Caster)) //Within cob 3 (Play two)
                    {
                        yield return StartCoroutine(Activate(e1));
                        yield return StartCoroutine(Activate(effects.Dequeue()));
                        i++;
                    }
                    else //Within cob 3 (Play one, because the next is from the same knight)
                    {
                        yield return StartCoroutine(Activate(e1));
                    }
                }
                else if (e1.Effect is IBlockable) //Within cob 2 without block
                {
                    yield return StartCoroutine(Activate(e1));
                }
            }
        }

        private IEnumerator Activate(EffectData e)
        {
            e.Effect.Activate(e.Caster, GetOtherKnight(e.Caster));
            yield return new WaitForSeconds(e.Effect.Duration());
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
    }
}