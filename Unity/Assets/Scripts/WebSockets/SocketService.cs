using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(MessageHandler))]
public class SocketService : MonoBehaviour {

    public MessageHandler handler;

    public UnityEvent OnOpponentCardPlayed;
    public UnityEvent<List<Card>, List<Card>> OnRecieve;

    void Awake()
    {
        handler = GetComponent<MessageHandler>();
    }

    void Start()
    {
        handler.Subscribe("CARDPLAYED", p => {
            // TODO: Actually handle the packet
            OnOpponentCardPlayed.Invoke();
            Debug.Log("Opponent played a card...");
        });
        handler.Subscribe("RESOLVE", p => {
            // TODO: Actually resolve the packet
            Debug.Log("Resolve...");
        });
    }

    void Recieve(List<Card> cards, List<Card> cards2)
    {
        OnRecieve.Invoke(cards, cards2);
    }

    void OnPlayCard(Card card)
    {
        Packet packet = new Packet() { Action = "CARDPLAYED" };
        packet.AddProperty("card", JsonConvert.SerializeObject(card));

        handler.SendPacket(packet);
    }

    //public void TestSendList()
    //{
    //    handler.Subscribe("TESTLIST", p => {
    //        TestRecieveList(p);
    //    });

    //    List<string> jsonList = new List<string>();
    //    Card c = new Card() { name = "testName"};
    //    jsonList.Add(JsonConvert.SerializeObject(c));
    //    jsonList.Add(JsonConvert.SerializeObject(c));
    //    jsonList.Add(JsonConvert.SerializeObject(c));

    //    Packet testPacket = new Packet() { Action = "TESTLIST" };
    //    testPacket.AddArrayProperty("cards", jsonList);

    //    handler.SendPacket(testPacket);
    //}

    //public void TestRecieveList(Packet packet)
    //{
    //    Debug.Log("Packet recieved: " + packet.Message);

    //    List<string> jsonList = packet.GetArrayProperty("cards");

    //    List<Card> cards = new List<Card>();
    //    foreach (string json in jsonList)
    //    {
    //        cards.Add((Card)JsonConvert.DeserializeObject(json));
    //    }

    //    Debug.Log("Cards recieved: " + cards.Count);
    //}
}
