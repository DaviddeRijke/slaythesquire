package com.sts.slaythesquire.sockets;

import java.io.IOException;
import java.io.InputStream;
import java.net.Socket;

public class ClientHandler implements Runnable {

    private final Socket client;
    private final MessageHandler messageHandler;

    public ClientHandler(Socket s, MessageHandler mh) {
        client = s;
        messageHandler = mh;
    }

    public void run() {
        try {
            InputStream in = client.getInputStream();
            while (client.isConnected()) {
                // Receiving bytes
                int len = client.getReceiveBufferSize();
                byte[] receivedBytes = new byte[len];
                in.read(receivedBytes);
                final String message = new String(receivedBytes);

//                System.out.println("Server received: " + message);
                messageHandler.handleMessage(new Packet(client, message));
            }
        } catch (IOException e) {
            e.printStackTrace();
            messageHandler.disconnect(client);
        }
    }
}
