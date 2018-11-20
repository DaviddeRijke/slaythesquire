using UnityEngine;

namespace Game
{
    /// <summary>
    /// There were too many not-useful-for-me functions in the GameManager, so I needed a custom one for a moment.
    /// </summary>
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