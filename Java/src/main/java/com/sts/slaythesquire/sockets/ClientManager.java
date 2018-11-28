package com.sts.slaythesquire.sockets;

import com.google.gson.Gson;
import com.sts.slaythesquire.matchmaking.MatchmakingPool;
import com.sts.slaythesquire.models.Card;
import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.repos.PlayerRepository;

import javax.persistence.criteria.CriteriaBuilder;
import javax.swing.*;
import java.util.ArrayList;
import java.util.List;
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

        messageHandler.subscribe("CONNECT", p -> {
            System.out.println("Handling connect packet...");
            Player player = getPlayerFromPacket(p);
            if (player == null){
                System.out.println("Player not found... :(");
                return;
            }
            player.setMessageHandler(messageHandler);
            matchmakingPool.initializePlayerForMatchmaking(player);

            Packet packet = new Packet();
            packet.setAction("CONNECTED");

            messageHandler.sendPacket(packet);
        });
        
        System.out.println("sending...");

        Packet packet = new Packet();
        packet.setAction("READYTOCONNECT");
        messageHandler.sendPacket(packet);
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
