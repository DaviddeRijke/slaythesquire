using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SocketServiceTester : MonoBehaviour {

    public InputField cardIdField;
    public InputField winnerIdField;
    public InputField dataStringField;

    private SocketService ss;
    public List<Card> cards;
    
	void Awake () {
        ss = GetComponent<SocketService>();
        cards = new List<Card>();
	}

    void Start()
    {
        ss.OnOpponentCardPlayed.AddListener(OnOpponentCardPlayed);
        ss.OnPlayPhase.AddListener(OnPlayPhase);
        ss.OnResolvePhase.AddListener(OnResolvePhase);
        ss.OnWinner.AddListener(OnWinner);
        ss.OnMatchVoid.AddListener(OnMatchVoid);
    }

    public void PlayedCard()
    {
        int cardId = 0;
        if (cardIdField != null && int.TryParse(cardIdField.text, out cardId))
        {
            Card card = new Card() { id = cardId };
            cards.Add(card);
            ss.OnPlayCard(card);
        }
    }

    public void SendPlayedCards()
    {
        ss.SendCardsPlayed(cards);
        cards.Clear();
    }

    public void SendStatus()
    {
        int winner = 0;
        string dataString = "";
        if (winnerIdField != null && int.TryParse(winnerIdField.text, out winner)
            && dataStringField != null)
        {
            ss.SendStatus(dataString, winner);
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
