package com.sts.slaythesquire.sockets;

import com.sts.slaythesquire.matchmaking.MatchmakingPool;
import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.repos.PlayerRepository;

import java.util.Timer;
import java.util.TimerTask;

public class ClientManager {

    private MatchmakingPool matchmakingPool;

    private PlayerRepository playerRepository;

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

    private void startHeartbeatTimerTask(int interval) {
        Timer timer = new Timer();
        TimerTask heartbeatTimerTask = new HeartbeatTimerTask(this);

        timer.schedule(heartbeatTimerTask,0, interval);
    }
}
