using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SocketService : MonoBehaviour {

    public MessageHandler handler;

    public UnityEvent<List<Card>, List<Card>> OnRecieve;

    void Awake()
    {
        handler.Subscribe("", p => {
            
        });
    }



    void Recieve(List<Card> cards, List<Card> cards2)
    {
        OnRecieve.Invoke(cards, cards2);
    }

    void OnPlayCard(Card card)
    {

    }
}
