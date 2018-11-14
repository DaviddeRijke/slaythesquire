using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.Hand
{
    public class TemporaryHandUI : MonoBehaviour
    {
        public GameObject View3DPrefab;
        public Transform Container;
        
        private TemporaryHand hand;
        private List<CardView3D> cardsInHand;
        public float spacing = 0.6f;
        public float distance = -0.03f;
        public float totalTwist = 20f;
        public float nudgeDown = 0.01f;

        void Awake()
        {
            cardsInHand = new List<CardView3D>();
            hand = GetComponent<TemporaryHand>();
        }

        void Start()
        {     
            hand.OnDiscard.AddListener(OnDiscard);
            hand.OnDraw.AddListener(OnDraw);
            hand.OnPlay.AddListener(OnPlay);
            
            FitCards();
        }

        private void OnDiscard(Card card)
        {
            RemoveInstance(card);
            FitCards();
        }

        private void OnDraw(Card card)
        {
            Instance(card);
            FitCards();
        }

        private void OnPlay(Card card)
        {
            RemoveInstance(card);
            FitCards();
        }

        /// <summary>
        /// This method assumes the instances of the CardView3D's have already been made, and put in the 'cardsInHand' collection
        /// </summary>
        public void FitCards()
        {          
            if (cardsInHand.Count == 0) return;
            float startTwist = 1f * (totalTwist / 2f);
            float twistPerCard = totalTwist / cardsInHand.Count;

            for (int i = 0; i < cardsInHand.Count; i++)
            {
                Transform card = cardsInHand[i].gameObject.transform;

                float twist = startTwist - (i * twistPerCard);

                card.rotation = transform.rotation;
                card.Rotate(0f, 0f, twist);

                card.localPosition = new Vector3(transform.position.x - (spacing * cardsInHand.Count * 0.5f - spacing * 0.5f), 0f, 0f);
                card.localPosition += new Vector3(i * spacing, -Mathf.Abs(twist * nudgeDown), distance * i);
            }
        }

        private void Instance(Card card)
        {
            var go = Instantiate(View3DPrefab, Container);
            var v3d = go.GetComponent<CardView3D>();
            v3d.card = card;
            cardsInHand.Add(v3d);
        }

        private void RemoveInstance(Card card)
        {
            foreach(var v3d in cardsInHand.ToArray())
            {
                if (v3d.card == card)
                {
                    cardsInHand.Remove(v3d);
                    Destroy(v3d.gameObject);
                    break;
                }
            }
        }
    }
}