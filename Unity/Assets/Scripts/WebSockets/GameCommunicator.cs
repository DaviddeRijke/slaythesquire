using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameCommunicator : MonoBehaviour {

    private SocketService socketService;

    public UnityEvent OnOpponentCardPlayed = new UnityEvent();
    public UnityIntEvent OnPlayPhase = new UnityIntEvent();
    public UnityCardListEvent OnResolvePhase = new UnityCardListEvent();
    public UnityIntEvent OnWinner = new UnityIntEvent();
    public UnityEvent OnMatchVoid = new UnityEvent();
    public UnityEvent OnEndTurn = new UnityEvent();

    public CardContainer CardContainer;

    public int OwnPlayerId;
    public int OpponentPlayerId;

    void Awake()
    {
        socketService = GetComponent<SocketService>();

        if (socketService == null)
        {
            Debug.Log("No SocketService, cannot connect to server");
            Destroy(this);
        }

    }



    void Start()
    {
        socketService.OnPlayPhase.AddListener(PlayPhase);
        socketService.OnCardPlayed.AddListener(CardPlayed);
        socketService.OnEndTurn.AddListener(EndTurn);
        socketService.OnResolvePhase.AddListener(ResolvePhase);
        socketService.OnWinner.AddListener(Winner);
        socketService.OnMatchVoid.AddListener(MatchVoid);
    }

    public void PlayCard(Card card)
    {
        socketService.SendPlayedCard(card);
    }

    public void EndTurn()
    {
        socketService.SendEndTurn();
    }

    public void SendCardsPlayed(List<Card> cards)
    {
        socketService.SendCardsPlayed(cards);
    }

    public void SendStatus(string status, int winnerId = 0)
    {
        socketService.SendStatus(status, winnerId);
    }

    private void PlayPhase(Packet packet)
    {
        int turn = -1;
        if (int.TryParse(packet.GetProperty("turnCount"), out turn) && turn != -1)
        {
            //Debug.Log("Starting turn " + turn);
            OnPlayPhase.Invoke(turn);
        }
        else Debug.Log("Not an int: " + packet.GetProperty("turnCount"));
    }

    private void CardPlayed(Packet packet)
    {
        OnOpponentCardPlayed.Invoke();
    }

    private void EndTurn(Packet packet)
    {
        OnEndTurn.Invoke();
    }

    private void ResolvePhase(Packet packet)
    {
        List<string> jsonCards = packet.GetArrayProperty("cards");

        int[] cardIds = new int[jsonCards.Count];
        for (int i = 0; i < cardIds.Length; i++)
        {
            cardIds[i] = int.Parse(jsonCards[i]);
        }
        List<Card> opponentCards = new List<Card>();
        opponentCards = CardContainer.GetCards(cardIds);

        /*
        string debugMessage = "getting opponent's cards from ids..." + System.Environment.NewLine;
        debugMessage += "ids:" + System.Environment.NewLine;

        foreach (int i in cardIds)
        {
            debugMessage += "card id: " + i + System.Environment.NewLine;
        }

        debugMessage += "recieved cards:" + System.Environment.NewLine;

        foreach (Card c in opponentCards)
        {
            debugMessage += "card name: " + c.name + " with id: " + c.id + System.Environment.NewLine;
        }


        Debug.Log(debugMessage);
        */

        OnResolvePhase.Invoke(opponentCards);
    }

    private void Winner(Packet packet)
    {
        int winnerId = 0;
        if (int.TryParse(packet.GetProperty("playerId"), out winnerId) && winnerId != 0)
        {
            //Debug.Log("Winner is player " + winnerId);
            OnWinner.Invoke(winnerId);
        }
        else Debug.Log("Not an int: " + packet.GetProperty("playerId"));
    }

    private void MatchVoid(Packet packet)
    {
        OnMatchVoid.Invoke();
    }
}
