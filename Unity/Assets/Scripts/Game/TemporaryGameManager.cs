using UnityEngine;

namespace Game
{
    public class TemporaryGameManager : MonoBehaviour
    {
        public Player player;
        public IngameDeck deck;
        
        private void Awake()
        {
            deck.Init(player.decks[0]);
        }
    }
}