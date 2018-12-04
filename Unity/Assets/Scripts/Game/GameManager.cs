using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    /// <summary>
    /// There were too many not-useful-for-me functions in the GameManager, so I needed a custom one for a moment.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        public Player player;
        public IngameDeck deck;

        public bool AcceptCardInput;
        public static GameManager _instance;
        private Turn turnManager;
        public Text PhaseText;

        private void Awake()
        {
            deck.Init(player.decks[0]);
            _instance = this;
            turnManager = GetComponent<Turn>();
        }
        
        void Update () {
            turnManager.Execute();
        }

        public void SetPhaseText(string phaseText)
        {
            PhaseText.text = phaseText;
        }
    }
}