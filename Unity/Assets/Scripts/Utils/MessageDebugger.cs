using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MessageHandler))]
public class MessageDebugger : MonoBehaviour {

    private MessageHandler handler;

    public bool PrintMessageDebug = true;
    public bool PrintRecieveMessageDebug = true;
    public bool PrintSentMessageDebug = true;

    void Awake()
    {
        handler = GetComponent<MessageHandler>();
        handler.OnMessageRecievedEvent.AddListener(RecievedMessage);
        handler.OnMessageSentEvent.AddListener(SentMessage);
    }

    private void RecievedMessage(Packet p)
    {
        if (PrintMessageDebug && PrintRecieveMessageDebug)
        {
            Debug.Log("Recieved packet with type: " + p.Action + " with message: " + p.Message);
        }
    }

    private void SentMessage(Packet p)
    {
        if (PrintMessageDebug && PrintSentMessageDebug)
        {
            Debug.Log("Sent packet with type: " + p.Action + " with message: " + p.Message);
        }
    }

}
