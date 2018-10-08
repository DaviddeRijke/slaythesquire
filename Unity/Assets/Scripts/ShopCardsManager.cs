using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public class ShopCardsManager : MonoBehaviour
    {
        public List<CardView2D> CardViews;
        public List<CardView2D> filtered;

        void Start()
        {
            CardGenerator.OnCardsGenerated.AddListener(Init);
        }

        void Init(List<CardView2D> views)
        {
            CardViews = views;
            filtered = CardViews;
        }

        public void MockTag1()
        {
            Filter(new List<Tag> {Tag.GetMockData()[0]});
        }
        public void MockTag2()
        {
            Filter(new List<Tag> {Tag.GetMockData()[1]});
        }
        public void MockTag12()
        {
            Filter(new List<Tag> {Tag.GetMockData()[0], Tag.GetMockData()[1]});
        }

        public void Filter(List<Tag> tags)
        {
            CardViews.ForEach(cv => cv.Disable());         
            var cards = CardViews.Select(l => l.card).ToList().Filter(tags);
            Debug.Log(cards.Count);
            cards.ForEach(c => c.Enable());
        }
    }
}