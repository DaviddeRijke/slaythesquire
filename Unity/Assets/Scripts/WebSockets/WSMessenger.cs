using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;

public class WSMessenger : MonoBehaviour {

    public string ServerIp = "127.0.0.1";
    public int Port = 4343;
    public IPEndPoint serverAddress;
    
    void Start () {
        serverAddress = new IPEndPoint(IPAddress.Parse(ServerIp), Port);
    }
	
	public void SendString (string toSend) {
        //TODO: DOE IETS MET JSON

        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        clientSocket.Connect(serverAddress);

        // Sending
        int toSendLen = System.Text.Encoding.ASCII.GetByteCount(toSend);
        byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(toSend);
        clientSocket.Send(toSendBytes);

        // Receiving
        byte[] rcvBytes = new byte[clientSocket.ReceiveBufferSize];
        clientSocket.Receive(rcvBytes);

        string rcv = System.Text.Encoding.ASCII.GetString(rcvBytes);

        Debug.Log("Client received: " + rcv);

        clientSocket.Close();
    }
}
