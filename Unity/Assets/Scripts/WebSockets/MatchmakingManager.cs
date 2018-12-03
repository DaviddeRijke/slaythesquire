using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MessageHandler))]
public class MatchmakingManager : MonoBehaviour {

    public MessageHandler handler;

    public bool JoinedPool;
    
	void Awake () {
        handler = GetComponent<MessageHandler>();
	}

    public void ConnectToServer()
    {
        handler.Connect();
    }

    public void StartMatchmaking()
    {
        handler.Subscribe("JOINEDMATCHMAKING", p => {
            handler.Subscribe("MATCHED", p2 =>
            {
                Debug.Log("Matched with: " + p2.GetProperty("playerId"));
            });
            Debug.Log("JOINEDMATCHMAKING");
            JoinedPool = true;
        });

        Packet packet = new Packet() { Action = "JOINMATCHMAKING" };

        handler.SendPacket(packet);
    }
}
