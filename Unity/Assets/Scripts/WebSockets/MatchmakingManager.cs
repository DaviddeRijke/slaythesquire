using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MessageHandler))]
public class MatchmakingManager : MonoBehaviour {

    private MessageHandler handler;

    public bool JoinedPool;
    
	void Awake ()
    {
        handler = GetComponent<MessageHandler>();
	}

    public void ConnectToServer()
    {
        handler.Connect();
    }

    public void StartMatchmaking()
    {
        handler.Subscribe("JOINEDMATCHMAKING", JoinedMatchmaking());

        Packet packet = new Packet() { Action = "JOINMATCHMAKING" };

        handler.SendPacket(packet);
    }

    private Action<Packet> JoinedMatchmaking()
    {
        return p => {
            handler.Subscribe("MATCHED", Matched());
            Debug.Log("JOINEDMATCHMAKING");
            JoinedPool = true;
        };
    }

    private Action<Packet> Matched()
    {
        return p => {
            Debug.Log("Matched with: " + p.GetProperty("playerId"));
        };
    }
}
