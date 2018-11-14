using System.Threading;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using System;
using System.Collections;

public class WSMessenger : MonoBehaviour {

    public string ServerIp = "127.0.0.1";
    public int ServerPort = 4343;
    IPEndPoint serverAddress;

    Socket clientSocket;
    Thread listenerThread;

    public bool keepAlive = true;
    private bool terminateConnection = false;

    public bool IsConnected = false;

    public MatchmakingManager Matchmaking;

    void Start () {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            //SendPacket(new Packet("TESTMOVE"));

        if (terminateConnection)
        {
            DisconnectFromServer(true);
            terminateConnection = false;
        }
    }

    public void Connect()
    {
        serverAddress = new IPEndPoint(IPAddress.Parse(ServerIp), ServerPort);

        ConnectToServer();
    }

    private void DisconnectFromServer(bool connected)
    {
        Debug.Log("terminate");

        if (connected)
        {
            Packet packet = new Packet("DISCONNECT");
            SendPacket(packet);
        }
        
        if (clientSocket != null)
            clientSocket.Close();
        clientSocket = null;
    }

    private void ConnectToServer()
    {
        if (clientSocket != null)
            return;

        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        clientSocket.Connect(serverAddress);

        listenerThread = new Thread(new ThreadStart(ListenSocket));
        listenerThread.IsBackground = true;
        listenerThread.Start();

        //StartCoroutine(Heartbeat());
    }

	public void SendPacket(Packet packet)
    {
        Debug.Log("Sending message: " + packet.Message);
        byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(packet.Message);
        try
        {
            if (clientSocket != null)
                clientSocket.Send(toSendBytes);
        } catch (SocketException e)
        {
            DisconnectFromServer(false);
        }
    }

    public void ListenSocket()
    {
        while (true)
        {
            byte[] rcvBytes = new byte[clientSocket.ReceiveBufferSize];
            clientSocket.Receive(rcvBytes);

            string message = System.Text.Encoding.ASCII.GetString(rcvBytes);
            Packet packet = new Packet(message);

            Debug.Log(packet.Message);

            HandleMessage(packet);
        }
    }

    public void HandleMessage(Packet packet)
    {
        /*if (packet.Function.Equals("MOVE"))
        {
            float moveAmount = float.Parse(packet.Args[0]);
            DoOnMainThread.ExecuteOnMainThread.Enqueue(() => { StartCoroutine(MoveCube(moveAmount)); });
        }
        else */if(packet.Function.Equals("READYTOCONNECT"))
        {
            Debug.Log("Ready to connect.");
        }
        else if (packet.Function.Equals("CONNECTED"))
        {
            IsConnected = true;
            Debug.Log("Connected with player id");
        }
        else if (packet.Function.Equals("JOINEDMATCHMAKING"))
        {
            DoOnMainThread.ExecuteOnMainThread.Enqueue(() => { ConfirmMatchmaking(); });
        } else if (packet.Function.Equals("MESSAGE"))
        {
            Debug.Log("Recieved message: " + packet.Args[0]);
        }
    }

    private void ConfirmMatchmaking()
    {
        Matchmaking.JoinedPool = true;
        Debug.Log("Joined matchmaking");
    }

    private IEnumerator MoveCube(float amount)
    {
        //testCube.Translate(new Vector3(amount, 0, 0));
        yield return null;
    }

    private IEnumerator Heartbeat()
    {
        while (keepAlive)
        {
            yield return new WaitForSeconds(1f);
            Packet packet = new Packet("HEARTBEAT");
            SendPacket(packet);
        }
        Debug.Log("stopped heartbeat");
        terminateConnection = true;
    }

    void OnApplicationQuit()
    {
        if (clientSocket == null)
        {
            return;
        }

        if (clientSocket.Connected)
        {
            DisconnectFromServer(true);
        }
    }
}
