package com.sts.slaythesquire.sockets;

import com.sts.slaythesquire.repos.PlayerRepository;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class SocketListener implements Runnable {

    private ServerSocket serverSocket;
    private MessageHandler handler;

    private boolean running = true;

    public SocketListener(ServerSocket serverSocket, MessageHandler handler) {
        this.serverSocket = serverSocket;
        this.handler = handler;
    }

    public void run() {
        try {
            //serverSocket = new ServerSocket(4343, 10);
            System.out.println("Server running on: " + serverSocket.getLocalSocketAddress());

            //handler = new MessageHandler();

            while (running) {
                listenSocket();
            }

            serverSocket.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public void shutdown(){
        running = false;
    }

    private void listenSocket() throws IOException {
        // Wait for client
        Socket client = serverSocket.accept();
        String clientIp = client.getInetAddress().getHostAddress();
        System.out.println("Connection from: " + clientIp);

        //TODO: control on what thread this runs, don't use .run().... :'(
        Runnable clientHandler = new ClientHandler(client, handler);
        clientHandler.run();
    }
}
