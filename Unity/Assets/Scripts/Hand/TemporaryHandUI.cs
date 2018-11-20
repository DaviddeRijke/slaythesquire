using System.Collections.Generic;
using UnityEngine;

//Namespace cannot be fixed, because there is a class Hand in folder Hand at the moment (my bad, should rename folder)
namespace DefaultNamespace.Hand
{
    [RequireComponent(typeof(TemporaryHand))]
    public class TemporaryHandUI : MonoBehaviour
    {
        //The prefab for the View3D, that can be instantiated for any card drawn from the deck
        public GameObject View3DPrefab;
        
        //The transform container under which the CardView3Ds will be placed in the inspector.
        public Transform Container;
        
        //Links to the hand where this is the UI from
        private TemporaryHand hand;
        
        //Links to the UI of the cards in hand.
        //'Card' is accessible here, but should not be used, as this is an UI class
        private List<CardView3D> cardsInHand;
        
        //The values needed for the layout of the hand, as made by Bob
        [Header("Holder")]
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
            
            //This should be redundant, however, if there are any cards in the hand that are in there by default through the inspector
            //(or for example the Mana card in Hearthstone) it won't break the system.
            FitCards();
        }

        /// <summary>
        /// Listens to the Hand calling the OnDiscard event. Physical instance of the card will be removed, and the visuals of the hand will adapt.
        /// </summary>
        /// <param name="card">the card to be removed. The RemoveInstance method makes sure the View3D is also removed</param>
        private void OnDiscard(Card card)
        {
            RemoveInstance(card);
            FitCards();
        }

        /// <summary>
        /// Listens to the Hand calling the OnDraw event. Physical instance of the card will be created, and the visuals of the hand will adapt.
        /// </summary>
        /// <param name="card">the card to be added to the hand. The Instance method creates an View3D</param>
        private void OnDraw(Card card)
        {
            Instance(card);
            FitCards();
        }

        /// <summary>
        /// Listens to the OnPlay calling the OnPlay event.
        /// Because this is not further implemented, I just let it remove the card, but don't call Discard for that,
        /// to keep our options open.
        /// </summary>
        /// <param name="card"></param>
        private void OnPlay(Card card)
        {
            RemoveInstance(card);
            FitCards();
        }

        /// <summary>
        /// This method assumes the instances of the CardView3D's have already been made, and put in the 'cardsInHand' collection.
        /// It then layouts the CardViews.
        ///
        /// This method could be added to an UnityAction which can be passed to the events instead of the current listeners,
        /// because it is executed after all three methods.
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

        /// <summary>
        /// Creates an View3D instance of the passed card.
        /// </summary>
        /// <param name="card">The card of which a View3D needs to be created.</param>
        private void Instance(Card card)
        {
            var go = Instantiate(View3DPrefab, Container);
            var v3D = go.GetComponent<CardView3D>();
            v3D.card = card;
            cardsInHand.Add(v3D);
        }

        /// <summary>
        /// Searches the View3D for given card, and removes it.
        ///
        /// If someone knows an more efficient way, feel free to refactor
        /// </summary>
        /// <param name="card">The card of which the View3D should be destroyed</param>
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