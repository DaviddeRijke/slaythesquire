using System.Collections;
using Api;
using UnityEngine;

namespace DefaultNamespace
{
    public class CardLoader : MonoBehaviour
    {
        public CardContainer Container;

        public void GetAllCards()
        {
            RestController.Instance.Get<Card>("/cards", Container);
            StartCoroutine(waitandsetactive());
        }

        public IEnumerator waitandsetactive()
        {
            yield return new WaitForSeconds(1);
            gameObject.GetComponent<CardGenerator>().enabled = true;
        }
    }
}