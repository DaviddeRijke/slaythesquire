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
        }
    }
}