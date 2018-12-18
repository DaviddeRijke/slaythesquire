using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SocketServiceTester : MonoBehaviour {

    public InputField cardIdField;
    public InputField winnerIdField;
    public InputField dataStringField;

    public int PlayerId = 1;

    private MatchmakingCommunicator matchmakingCommunicator;
    private GameCommunicator gameCommunicator;

    private List<Card> playedCards = new List<Card>();
    
	void Awake () {

        matchmakingCommunicator = GetComponent<MatchmakingCommunicator>();
        gameCommunicator = GetComponent<GameCommunicator>();

        if (matchmakingCommunicator == null || gameCommunicator == null)
        {
            Debug.Log("No Communicators, terminating...");
            Destroy(this);
        }

        //ss = GetComponent<SocketService>();
	}

    void Start()
    {
        gameCommunicator.OnOpponentCardPlayed.AddListener(OnOpponentCardPlayed);
        gameCommunicator.OnPlayPhase.AddListener(OnPlayPhase);
        gameCommunicator.OnResolvePhase.AddListener(OnResolvePhase);
        gameCommunicator.OnWinner.AddListener(OnWinner);
        gameCommunicator.OnMatchVoid.AddListener(OnMatchVoid);
    }

    public void ConnectToServer()
    {
        matchmakingCommunicator.ConnectToServer(PlayerId);
    }

    public void PlayedCard()
    {
        int cardId = 0;
        if (cardIdField != null && int.TryParse(cardIdField.text, out cardId))
        {
            Card card = new Card() { id = cardId };
            playedCards.Add(card);
            gameCommunicator.PlayCard(card);
        }
    }

    public void SendConfirmMatch()
    {
        matchmakingCommunicator.ConfirmMatch();
    }

    public void SendEndTurn()
    {
        gameCommunicator.EndTurn();
    }

    public void SendPlayedCards()
    {
        gameCommunicator.SendCardsPlayed(playedCards);
        playedCards.Clear();
    }

    public void SendStatus()
    {
        int winner = 0;
        if (winnerIdField != null && int.TryParse(winnerIdField.text, out winner)
            && dataStringField != null)
        {
            gameCommunicator.SendStatus(dataStringField.text, winner);
        }
    }

    public void OnOpponentCardPlayed()
    {
        Debug.Log("Opponent Card played");
    }

    public void OnPlayPhase(int turn)
    {
        Debug.Log("PlayPhase " + turn);
    }

    public void OnResolvePhase(List<Card> cards)
    {
        Debug.Log("ResolvePhase " + cards.Count);
    }

    public void OnWinner(int playerId)
    {
        Debug.Log("Winner " + playerId);
    }

    public void OnMatchVoid()
    {
        Debug.Log("Match declared void.");
    }
}
