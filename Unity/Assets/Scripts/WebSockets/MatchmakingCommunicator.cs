using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MatchmakingCommunicator : MonoBehaviour {

    public SocketService socketService;

    public UnityEvent OnJoinedMatchmaking = new UnityEvent();
    public UnityIntEvent OnMatchedWithPlayer = new UnityIntEvent();

    
	void Awake ()
    {
        socketService = GetComponent<SocketService>();

        if (socketService == null)
        {
            Debug.Log("No SocketService, cannot connect to server");
            Destroy(this);
        }

	}

    public void ConnectToServer(int playerId)
    {
        socketService.OnConnected.AddListener(StartMatchmaking);
        socketService.ConnectToServer(playerId);
    }

    public void StartMatchmaking()
    {
        socketService.OnJoinedMatchmaking.AddListener(JoinedMatchmaking);
        socketService.OnMatchedWithPlayer.AddListener(MatchedWithPlayer);
        socketService.StartMatchmaking();

    }

    private void JoinedMatchmaking(Packet p)
    {
        OnJoinedMatchmaking.Invoke();
    }

    private void MatchedWithPlayer(Packet p)
    {
        int playerId = 0;
        bool found = int.TryParse(p.GetProperty("playerId"), out playerId);

        if (!found)
        {
            Debug.Log("Could not parse player id");
            return;
        }

        OnMatchedWithPlayer.Invoke(playerId);

    }

    public void ConfirmMatch()
    {
        socketService.SendConfirmMatch();
    }

    /*
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
    */
}
