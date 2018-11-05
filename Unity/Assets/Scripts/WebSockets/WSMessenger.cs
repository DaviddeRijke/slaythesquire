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

    public Transform testCube;
    public bool keepAlive = true;
    private bool terminateConnection = false;

    void Start () {
        serverAddress = new IPEndPoint(IPAddress.Parse(ServerIp), ServerPort);
        
        ConnectToServer();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SendPacket(new Packet("TESTMOVE"));

        if (terminateConnection)
        {
            DisconnectFromServer(true);
            terminateConnection = false;
        }
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
        SendPacket(new Packet("CONNECT"));

        listenerThread = new Thread(new ThreadStart(ListenSocket));
        listenerThread.IsBackground = true;
        listenerThread.Start();

        //StartCoroutine(Heartbeat());
    }

	public void SendPacket(Packet packet)
    {
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
        if (packet.Function.Equals("MOVE"))
        {
            float moveAmount = float.Parse(packet.Args[0]);
            DoOnMainThread.ExecuteOnMainThread.Enqueue(() => { StartCoroutine(MoveCube(moveAmount)); });
        }
    }

    private IEnumerator MoveCube(float amount)
    {
        testCube.Translate(new Vector3(amount, 0, 0));
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
        DisconnectFromServer(true);
    }
}
