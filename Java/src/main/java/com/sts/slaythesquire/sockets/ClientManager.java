package com.sts.slaythesquire.sockets;

import com.sts.slaythesquire.matchmaking.MatchmakingPool;
import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.repos.PlayerRepository;

import java.net.Socket;
import java.util.ArrayList;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;

public class ClientManager {

    private List<Socket> clients = new ArrayList<>();

    private MatchmakingPool matchmakingPool;

    private PlayerRepository playerRepository;

    public List<Socket> getClients() {
        return clients;
    }

    public ClientManager(PlayerRepository playerRepository, MatchmakingPool matchmakingPool) {
        //startHeartbeatTimerTask(2000);
        this.playerRepository = playerRepository;
        this.matchmakingPool = matchmakingPool;
    }

    public synchronized void addNewMessageHandler(MessageHandler messageHandler){

        System.out.println("subscribing to CONNECT");

        messageHandler.subscribe("CONNECT", p ->{
            System.out.println("Handling connect packet...");
            Player player = getPlayerFromPacket(p);
            if (player == null){
                System.out.println("Player not found... :(");
                return;
            }
            player.setMessageHandler(messageHandler);
            matchmakingPool.initializePlayerForMatchmaking(player);

            messageHandler.sendPacket(new Packet("CONNECTED"));
        });

        System.out.println("sending...");
        messageHandler.sendPacket(new Packet("READYTOCONNECT"));
    }

    private synchronized Player getPlayerFromPacket(Packet packet){
        int id;
        try{
            id = Integer.parseInt(packet.getArgs()[0].trim());
        } catch (NumberFormatException e){
            System.out.println("This is not a number... : " + packet.getArgs()[0]);
            return null;
        }

        return playerRepository.findById(id).orElse(null);
    }

    /*
    public boolean addClient(Socket client) {
        if (clients.contains(client)) {
            return false;
        }

        clients.add(client);
        return true;
    }

    public boolean removeClient(Socket client) {
        if (!clients.contains(client)) {
            return false;
        }

        clients.remove(client);
        //connectedSockets.remove(client);
        return true;
    }

    public boolean keepAlive(Socket client) {
        if (connectedSockets.contains(client)) {
            return false;
        }

        connectedSockets.add(client);
        return true;
    }

    public void addPlayerToMatchmaking(Player player){
        try {
            matchmakingPool.addPlayerToPool(player);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

    public void removePlayerFromMatchmaking(Player player){
        try {
            matchmakingPool.removePlayerFromPool(player);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
*/
    private void startHeartbeatTimerTask(int interval) {
        Timer timer = new Timer();
        TimerTask heartbeatTimerTask = new HeartbeatTimerTask(this);

        timer.schedule(heartbeatTimerTask,0, interval);
    }
}
