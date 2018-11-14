using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchmakingManager : MonoBehaviour {

    public WSMessenger SocketMessenger;

    public bool Connected;

    public bool JoinedPool;

    public string Id;

    public InputField IdInput;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ConnectToServer()
    {
        StartCoroutine(ConnectRoutine());
    }

    public void ConnectWithPlayerID()
    {
        Id = IdInput.text;
        SocketMessenger.SendPacket(new Packet("CONNECT/" + Id));
    }


    public void StartMatchmaking()
    {
        SocketMessenger.SendPacket(new Packet("JOINMATCHMAKING"));
    }

    IEnumerator ConnectRoutine()
    {
        SocketMessenger.Connect();

        while (!SocketMessenger.IsConnected)
        {
            yield return null;
        }

        Connected = true;

    }
}
