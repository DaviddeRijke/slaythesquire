package com.sts.slaythesquire.sockets;

import com.sts.slaythesquire.matchmaking.MatchmakingPool;
import com.sts.slaythesquire.matchmaking.matchmakers.RandomMatchmaker;
import com.sts.slaythesquire.repos.PlayerRepository;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class ServerSocketListener implements Runnable {

    private ServerSocket serverSocket;
    private ClientManager clientManager;

    private ExecutorService pool = Executors.newCachedThreadPool();

    private boolean running = true;

    public ServerSocketListener(ServerSocket serverSocket, ClientManager clientManager) {
        this.serverSocket = serverSocket;
        this.clientManager = clientManager;
    }

    /*public ServerSocketListener(ServerSocket serverSocket, PlayerRepository playerRepository) {
        this.serverSocket = serverSocket;
        this.clientManager = new ClientManager(playerRepository, new MatchmakingPool(new RandomMatchmaker(), 20000, 10000));
    }*/

    public void run() {
        try {
            System.out.println("Server running on: " + serverSocket.getLocalSocketAddress());

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
        Socket clientSocket = serverSocket.accept();
        String clientIp = clientSocket.getInetAddress().getHostAddress();
        System.out.println("Connection from: " + clientIp + " Starting Client Socket Listener.");

        //TODO: control on what thread this runs, don't use .run().... :'(

        MessageHandler mh = new MessageHandler(clientSocket);
        Runnable listener  =new ClientSocketListener(mh);

        pool.submit(listener);

        System.out.println("Adding message handler to client manager.");
        clientManager.addNewMessageHandler(mh);
    }
}
