using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(MessageHandler))]
public class SocketService : MonoBehaviour {

    private MessageHandler handler;

    /*
    public UnityEvent OnOpponentCardPlayed;
    public UnityIntEvent OnPlayPhase = new UnityIntEvent();
    public UnityCardListEvent OnResolvePhase = new UnityCardListEvent();
    public UnityIntEvent OnWinner = new UnityIntEvent();
    public UnityEvent OnMatchVoid;
    public UnityEvent OnEndTurn;
    */

    public PacketEvent OnJoinedMatchmaking = new PacketEvent();
    public PacketEvent OnMatchedWithPlayer = new PacketEvent();

    public PacketEvent OnPlayPhase = new PacketEvent();
    public PacketEvent OnCardPlayed = new PacketEvent();
    public PacketEvent OnEndTurn = new PacketEvent();
    public PacketEvent OnResolvePhase = new PacketEvent();
    public PacketEvent OnWinner = new PacketEvent();
    public PacketEvent OnMatchVoid = new PacketEvent();

    public UnityEvent OnConnected = new UnityEvent();

    //public static SocketService Instance;

    private void Awake()
    {
        //if (Instance != null)
        //{
        //    Destroy(Instance);
        //}
        //Instance = this;

        handler = GetComponent<MessageHandler>();
        //playedCards = new List<Card>();
    }

    private void Start()
    {
        //handler.Subscribe("PLAYEDCARD", CardPlayed());
        //handler.Subscribe("ENDTURN", EndTurn());
        //handler.Subscribe("PLAYPHASE", PlayPhase());
        //handler.Subscribe("RESOLVEPHASE", ResolvePhase());
        //handler.Subscribe("WINNER", Winner());
        //handler.Subscribe("MATCHVOID", MatchVoid());
    }

    public void ConnectToServer(int playerId)
    {
        handler.OnConnectedEvent.AddListener(Connected);
        handler.Connect(playerId);
    }

    private void Connected(Packet p)
    {
        OnConnected.Invoke();
    }

    public void StartMatchmaking()
    {

        handler.Subscribe("JOINEDMATCHMAKING", p => 
        {
            handler.Subscribe("MATCHED", p2 => OnMatchedWithPlayer.Invoke(p2));

            SubscribeToGameMessages();

            OnJoinedMatchmaking.Invoke(p);
        });


        Packet packet = new Packet() { Action = "JOINMATCHMAKING" };

        handler.SendPacket(packet);

    }

    private void SubscribeToGameMessages()
    {
        handler.Subscribe("PLAYPHASE",      p => OnPlayPhase.Invoke(p));
        handler.Subscribe("PLAYEDCARD",     p => OnCardPlayed.Invoke(p));
        handler.Subscribe("ENDTURN",        p => OnEndTurn.Invoke(p));
        handler.Subscribe("RESOLVEPHASE",   p => OnResolvePhase.Invoke(p));
        handler.Subscribe("WINNER",         p => OnWinner.Invoke(p));
        handler.Subscribe("MATCHVOID",      p => OnMatchVoid.Invoke(p));
    }

    public void SendConfirmMatch()
    {
        Packet packet = new Packet() { Action = "CONFIRMMATCH" };

        handler.SendPacket(packet);
    }

    public void SendPlayedCard(Card card)
    {

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

        //Debug.Log("Sending status...");
        handler.SendPacket(packet);
    }
    
    /*
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
            Debug.Log("Ending turn...");
            OnEndTurn.Invoke();
        };
    }

    private Action<Packet> PlayPhase()
    {
        return p => {
            int turn = -1;
            if (int.TryParse(p.GetProperty("turnCount"), out turn) && turn != -1)
            {
                Debug.Log("Starting turn " + turn);
                OnPlayPhase.Invoke(turn);
            }
            else Debug.Log("Not an int: " + p.GetProperty("turnCount"));
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
    */
}
