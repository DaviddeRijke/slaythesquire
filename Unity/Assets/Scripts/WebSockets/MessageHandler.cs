﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

public class MessageHandler : MonoBehaviour {

    public string ServerIp = "127.0.0.1";
    public int ServerPort = 4343;
    private IPEndPoint serverAddress;

    private Socket socket;

    private bool isConnected;

    private Dictionary<string, List<Action<Packet>>> topics;

    public PacketEvent OnReadyToConnectEvent = new PacketEvent();
    public PacketEvent OnConnectedEvent = new PacketEvent();

    public PacketEvent OnMessageRecievedEvent = new PacketEvent();
    public PacketEvent OnMessageSentEvent = new PacketEvent();

    void Awake()
    {
        topics = new Dictionary<string, List<Action<Packet>>>();
    }

    public void Connect(int playerId)
    {
        if (isConnected)
            return;

        serverAddress = new IPEndPoint(IPAddress.Parse(ServerIp), ServerPort);

        ConnectToServer(playerId);
    }

    private void ConnectToServer(int playerId)
    {
        if (socket != null)
            return;

        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        Subscribe("READYTOCONNECT", p => {

            Subscribe("CONNECTED", p2 => {
                isConnected = true;
                OnConnectedEvent.Invoke(p2);
            });

            Packet packet = new Packet() { Action = "CONNECT" };
            packet.AddProperty("playerId", playerId.ToString());

            SendPacket(packet);

            OnReadyToConnectEvent.Invoke(p);

        });

        try
        {
            socket.Connect(serverAddress);

            Thread listenerThread = new Thread(new ThreadStart(ListenSocket))
            {
                IsBackground = true
            };

            listenerThread.Start();

        } catch (SocketException e)
        {
            Debug.Log("Failed to connect.");
            DisconnectFromServer();
        }
    }

    public void ListenSocket()
    {
        while (true)
        {
            byte[] recievePacket = new byte[socket.ReceiveBufferSize];
            socket.Receive(recievePacket);

            int count;
            for (count = 0; count < recievePacket.Length; ++count)
            {
                if (recievePacket[count] == 0)
                    break;
            }
            
            string message = System.Text.Encoding.ASCII.GetString(recievePacket, 0, count);
            Packet packet = new Packet(message);

            OnMessageRecievedEvent.Invoke(packet);
            HandleMessage(packet);
        }
    }

    public void Subscribe(string topic, Action<Packet> action)
    {
        if (!topics.ContainsKey(topic))
        {
            topics.Add(topic, new List<Action<Packet>>());
        }
        topics[topic].Add(action);
    }

    public void HandleMessage(Packet packet)
    {
        List<Action<Packet>> actions = topics[packet.Action];

        if (actions != null)
        {
            foreach (Action<Packet> action in actions)
            {
                DoOnMainThread.ExecuteOnMainThread.Enqueue(() => { action.Invoke(packet); });
            }
        }
        else
        {
            Debug.Log("No subscription on " + packet.Action);
        }
    }

    public void SendPacket(Packet packet)
    {
        OnMessageSentEvent.Invoke(packet);
        byte[] toSendBytes = System.Text.Encoding.ASCII.GetBytes(packet.Message);
        try
        {
            if (socket != null)
                socket.Send(toSendBytes);
        }
        catch (SocketException e)
        {
            isConnected = false;
            DisconnectFromServer();
        }
    }

    private void DisconnectFromServer()
    {
        Debug.Log("terminate");

        if (isConnected)
        {
            Packet packet = new Packet() { Action = "DISCONNECT" };

            SendPacket(packet);
            isConnected = false;
        }

        topics.Clear();

        if (socket != null)
            socket.Close();
        socket = null;
    }

    void OnApplicationQuit()
    {
        DisconnectFromServer();
    }
}
