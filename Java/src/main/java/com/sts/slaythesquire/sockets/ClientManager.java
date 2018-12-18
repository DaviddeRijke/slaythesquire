package com.sts.slaythesquire.sockets;

import com.sts.slaythesquire.matchmaking.MatchmakingPool;
import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.repos.PlayerRepository;
import com.sts.slaythesquire.utils.threading.ReadWriteMonitor;
import java.util.LinkedList;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;

public class ClientManager {

    private MatchmakingPool matchmakingPool;

    private PlayerRepository playerRepository;

    private List<Player> connectedPlayers = new LinkedList<>();
    private ReadWriteMonitor playersMonitor = new ReadWriteMonitor();

    public ClientManager(PlayerRepository playerRepository, MatchmakingPool matchmakingPool) {
        //startHeartbeatTimerTask(2000);
        this.playerRepository = playerRepository;
        this.matchmakingPool = matchmakingPool;
    }

    public synchronized void addNewMessageHandler(MessageHandler messageHandler){

        System.out.println("subscribing to CONNECT");

        messageHandler.subscribe("CONNECT", p -> {
            System.out.println("Handling connect packet...");
            Player player = getPlayerFromPacket(p);
            if (player == null){
                System.out.println("Player not found... :(");
                return;
            }

            try {
                if (isPlayerAlreadyConnected(player)){
                    Packet alreadyConnectedPacket = new Packet();
                    alreadyConnectedPacket.setAction("ALREADYCONNECTED");
                    messageHandler.sendPacket(alreadyConnectedPacket);
                    System.out.println("Player " + player.getUsername() + "was already connected, could not connect again...");
                    return;
                }
            } catch (InterruptedException e) {
                e.printStackTrace();
            }

            messageHandler.subscribe("DISCONNECT", p2 -> {
                try {
                    removePlayer(player);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            });

            player.setMessageHandler(messageHandler);
            matchmakingPool.initializePlayerForMatchmaking(player);

            try {
                addPlayer(player);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }

            Packet packet = new Packet();
            packet.setAction("CONNECTED");

            messageHandler.sendPacket(packet);
        });
        
        System.out.println("sending...");

        Packet packet = new Packet();
        packet.setAction("READYTOCONNECT");
        messageHandler.sendPacket(packet);
    }

    private void addPlayer(Player player) throws InterruptedException {
        playersMonitor.enterWriter();

        connectedPlayers.add(player);

        playersMonitor.exitReader();
    }

    private void removePlayer(Player player) throws InterruptedException {
        playersMonitor.enterWriter();

        Player playerToRemove = connectedPlayers.stream().filter(p -> player.getId() == p.getId()).findFirst().orElse(null);
        connectedPlayers.remove(playerToRemove);

        playersMonitor.exitReader();
    }

    private boolean isPlayerAlreadyConnected(Player player) throws InterruptedException {

        boolean connected = false;

        playersMonitor.enterReader();

        connected = connectedPlayers.stream().anyMatch(p -> p.getId() == player.getId());

        playersMonitor.exitReader();

        return connected;
    }

    private synchronized Player getPlayerFromPacket(Packet packet){
        int id;
        try{
            id = Integer.parseInt(packet.getProperty("playerId"));
        } catch (NumberFormatException e){
            System.out.println("This is not a number... : " + packet.getProperty("playerId"));
            return null;
        }

        return playerRepository.findById(id).orElse(null);
    }

    private void startHeartbeatTimerTask(int interval) {
        Timer timer = new Timer();
        TimerTask heartbeatTimerTask = new HeartbeatTimerTask(this);

        timer.schedule(heartbeatTimerTask,0, interval);
    }
}
