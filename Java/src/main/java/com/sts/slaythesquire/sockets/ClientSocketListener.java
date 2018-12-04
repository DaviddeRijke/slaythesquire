package com.sts.slaythesquire.sockets;

import java.io.IOException;
import java.io.InputStream;
import java.net.Socket;
import java.net.SocketException;

public class ClientSocketListener implements Runnable {

    private final Socket clientSocket;
    private final MessageHandler messageHandler;

    private boolean connected = true;

    public ClientSocketListener(MessageHandler mh) {
        clientSocket = mh.getSocket();
        messageHandler = mh;
    }

    public void setConnected(boolean connected) {
        this.connected = connected;
    }

    public void run() {
        try {

            System.out.println("Client Socket Listener started.");

            InputStream in = clientSocket.getInputStream();
            while (connected) {
                // Receiving bytes
                int len = clientSocket.getReceiveBufferSize();
                byte[] receivedBytes = new byte[len];
                in.read(receivedBytes);
                final String message = new String(receivedBytes);

                System.out.println("Server received: " + message);
                messageHandler.handleMessage(new Packet(message));
            }
        } catch (IOException e) {
            System.out.println("Connection lost, closing socket");
            connected = false;
            closeSocket();
        }
    }

    private void closeSocket() {
        try {
            clientSocket.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
