using System.Collections.Generic;
using System.Linq;
using Api;
using DefaultNamespace;
using UnityEngine;

[CreateAssetMenu(fileName= "Container", menuName="CardContainer")]
public class CardContainer : ScriptableObject, ILoadable
{
        public List<Card> Cards;

        public void SetData<T>(T[] entities)
        {
                if (!(entities is Card[]))
                {
                        Debug.Log("Data invalid");
                        return;
                }

                Cards = (entities as Card[]).ToList();

        }
}