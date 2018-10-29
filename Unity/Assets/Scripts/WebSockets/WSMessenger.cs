using System.Threading;
using System.Net;
using System.Net.Sockets;
using UnityEngine;
using System;

public class WSMessenger : MonoBehaviour {

    public string ServerIp = "127.0.0.1";
    public int ServerPort = 4343;
    public IPEndPoint serverAddress;

    Socket clientSocket;

    public Thread listenerThread;
    
    void Start () {
        serverAddress = new IPEndPoint(IPAddress.Parse(ServerIp), ServerPort);

        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        clientSocket.Connect(serverAddress);
        SendString("CONNECT");

        Thread t = new Thread(new ThreadStart(listenSocket));
        t.Start();
    }

    private void ConnectToServer()
    {
        listenerThread = new Thread(new ThreadStart(listenSocket));
        listenerThread.IsBackground = true;
        listenerThread.Start();
    }
	public void SendString(string toSend)
    {
        byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(toSend);
        clientSocket.Send(toSendBytes);        
    }

    public void listenSocket()
    {
        while (true)
        {
            byte[] rcvBytes = new byte[clientSocket.ReceiveBufferSize];
            clientSocket.Receive(rcvBytes);

            string message = System.Text.Encoding.ASCII.GetString(rcvBytes);

            Debug.Log(message);
        }
    }
}
