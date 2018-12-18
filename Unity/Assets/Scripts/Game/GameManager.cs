using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    /// <summary>
    /// There were too many not-useful-for-me functions in the GameManager, so I needed a custom one for a moment.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        private GameCommunicator gameCommunicator;

        private int round;
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
            gameCommunicator = DDOLAccesser.GetObject().GetComponent<GameCommunicator>();
            gameCommunicator.OnPlayPhase.AddListener(OnPlayPhase);
            gameCommunicator.OnResolvePhase.AddListener(OnResolvePhase);
        }

        public void SetPhaseText(string phaseText)
        {
            PhaseText.text = phaseText;
        }

        public void EndTurn()
        {
            gameCommunicator.EndTurn();
        }

        private void OnPlayPhase(int turnId)
        {
            AcceptCardInput = true;

            round = turnId;
            Splash.instance.SetRoundNumber(round);
            Splash.instance.StartSplash();

            SetPhaseText("Play Phase");
        }

        private void OnResolvePhase(List<Card> cards)
        {
            AcceptCardInput = false;

            SetPhaseText("Resolve Phase");
        }
    }
}