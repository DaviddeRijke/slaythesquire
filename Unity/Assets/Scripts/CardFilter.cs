using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public static class CardFilter
    {
        /// <summary>
        /// Extension Method
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="tags">The list of tags, it should be filtered on</param>
        /// <returns>returns a new List</returns>
        public static List<Card> Filter(this List<Card> entities, List<Tag> tags)
        {
            Debug.Log(entities.Count);
            Debug.Log(tags.Count);
            var results = new List<Card>();
            foreach (var card in entities)
            {
                if (card.ContainsTag(tags))
                {
                    results.Add(card);
                }
            }
            return results;
        }

        private static bool ContainsTag(this Card card, List<Tag> tags)
        {
            bool ret = true;
            foreach(var tag in tags)
            {
                if (!card.tags.Contains(tag))
                {
                    ret = false;
                }
            }
            return ret;
        }
    }
}