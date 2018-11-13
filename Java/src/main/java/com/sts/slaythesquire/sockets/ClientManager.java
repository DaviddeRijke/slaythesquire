package com.sts.slaythesquire.sockets;

import com.sts.slaythesquire.matchmaking.MatchmakingPool;
import com.sts.slaythesquire.matchmaking.matchmakers.RandomMatchmaker;
import com.sts.slaythesquire.models.Player;

import java.net.Socket;
import java.util.ArrayList;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;

public class ClientManager {

    private List<Socket> clients = new ArrayList<>();
    private List<Socket> connectedSockets = new ArrayList<>();

    private MatchmakingPool matchmakingPool;

    public List<Socket> getClients() {
        return clients;
    }
    public List<Socket> getConnectedSockets() {
        return connectedSockets;
    }

    public ClientManager() {
        //startHeartbeatTimerTask(2000);
        matchmakingPool = new MatchmakingPool(new RandomMatchmaker(), 10000, 20000);
    }

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
        connectedSockets.remove(client);
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

    private void startHeartbeatTimerTask(int interval) {
        Timer timer = new Timer();
        TimerTask heartbeatTimerTask = new HeartbeatTimerTask(this);

        timer.schedule(heartbeatTimerTask,0, interval);
    }
}
