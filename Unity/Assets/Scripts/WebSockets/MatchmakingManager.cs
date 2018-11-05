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

    public void StartMatchmaking()
    {
        Id = IdInput.text;
        SocketMessenger.SendPacket(new Packet("STARTMATCHMAKING/"+ 1));
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
