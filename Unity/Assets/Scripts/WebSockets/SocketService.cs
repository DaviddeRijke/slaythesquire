using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(MessageHandler))]
public class SocketService : MonoBehaviour {

    private MessageHandler handler;
    public List<Card> playedCards;

    public UnityEvent OnOpponentCardPlayed;
    public UnityIntEvent OnPlayPhase;
    public UnityCardListEvent OnResolvePhase;
    public UnityIntEvent OnWinner;
    public UnityEvent OnMatchVoid;

    private void Awake()
    {
        handler = GetComponent<MessageHandler>();
        playedCards = new List<Card>();

        OnPlayPhase = new UnityIntEvent();
        OnResolvePhase = new UnityCardListEvent();
        OnWinner = new UnityIntEvent();
    }

    private void Start()
    {
        handler.Subscribe("PLAYEDCARD", CardPlayed());
        handler.Subscribe("ENDTURN", EndTurn());
        handler.Subscribe("PLAYPHASE", PlayPhase());
        handler.Subscribe("RESOLVEPHASE", ResolvePhase());
        handler.Subscribe("WINNER", Winner());
        handler.Subscribe("MATCHVOID", MatchVoid());
    }

    public void SendPlayedCard(Card card)
    {
        playedCards.Add(card);

        Packet packet = new Packet() { Action = "PLAYEDCARD" };
        packet.AddProperty("card", card.id);

        handler.SendPacket(packet);
    }

    public void SendEndTurn()
    {
        Packet packet = new Packet() { Action = "ENDTURN" };

        handler.SendPacket(packet);
    }

    public void SendCardsPlayed(List<Card> cards)
    {
        Packet packet = new Packet() { Action = "CARDSPLAYED" };

        List<string> cardIds = new List<string>();
        foreach (Card card in cards)
        {
            cardIds.Add(card.id.ToString());
        }
        packet.AddArrayProperty("cards", cardIds);

        handler.SendPacket(packet);
    }

    public void SendStatus(string status, int winnerId = 0)
    {
        Packet packet = new Packet() { Action = "STATUS" };
        packet.AddProperty("winner", winnerId);
        packet.AddProperty("data", status);

        Debug.Log("Sending status...");
        handler.SendPacket(packet);
    }
    
    private Action<Packet> CardPlayed()
    {
        return p => {
            Debug.Log("Opponent played a card...");
            OnOpponentCardPlayed.Invoke();
        };
    }

    private Action<Packet> EndTurn()
    {
        return p =>
        {
            SendCardsPlayed(playedCards);
        };
    }

    private Action<Packet> PlayPhase()
    {
        return p => {
            int turn = int.Parse(p.GetProperty("turn"));
            Debug.Log("Starting turn " + turn);
            OnPlayPhase.Invoke(turn);
        };
    }

    private Action<Packet> ResolvePhase()
    {
        return p => {
            List<string> jsonCards = p.GetArrayProperty("cards");

            int[] cardIds = new int[jsonCards.Count];
            for (int i = 0; i < cardIds.Length; i++)
            {
                cardIds[i] = int.Parse(jsonCards[i]);
            }
            List<Card> opponentCards = new List<Card>();
            //TODO: opponentCards = getCardsWithCardIds(cardIds);
            Debug.Log("TODO: Get cards from cardIds");

            OnResolvePhase.Invoke(opponentCards);
        };
    }

    private Action<Packet> Winner()
    {
        return p => {
            int winnerId = 0;
            if (int.TryParse(p.GetProperty("playerId"), out winnerId) && winnerId != 0)
            {
                Debug.Log("Winner is player " + winnerId);
                OnWinner.Invoke(winnerId);
            }
            else Debug.Log("Not an int: " + p.GetProperty("playerId"));
        };
    }

    private Action<Packet> MatchVoid()
    {
        return p => {
            Debug.Log("Match is declared void");
            OnMatchVoid.Invoke();
        };
    }
}
