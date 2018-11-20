using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

public class SocketListener {

    private Socket socket;
    private MessageHandler handler;

    public SocketListener(Socket socket, MessageHandler handler)
    {
        this.handler = handler;

        Thread listenerThread = new Thread(new ThreadStart(ListenSocket));
        listenerThread.IsBackground = true;
        listenerThread.Start();
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

            handler.HandleMessage(packet);
        }
    }

}
