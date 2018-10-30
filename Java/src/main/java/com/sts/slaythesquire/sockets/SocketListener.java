package com.sts.slaythesquire.sockets;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class SocketListener implements Runnable {

    private ServerSocket serverSocket;
    private MessageHandler handler;

    public void run() {
        try {
            boolean running = true;
            serverSocket = new ServerSocket(4343, 10);
            System.out.println("Server running on: " + serverSocket.getLocalSocketAddress());

            handler = new MessageHandler();

            while (running) {
                listenSocket();
            }

            serverSocket.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private void listenSocket() throws IOException {
        // Wait for client
        Socket client = serverSocket.accept();
        String clientIp = client.getInetAddress().getHostAddress();
        System.out.println("Connection from: " + clientIp);

        Runnable clientHandler = new ClientHandler(client, handler);
        clientHandler.run();
    }
}
