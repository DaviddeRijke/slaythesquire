package com.sts.slaythesquire.sockets;

import java.net.Socket;
import java.util.ArrayList;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;

public class ClientManager {

    private List<Socket> clients = new ArrayList<>();
    private List<Socket> connectedSockets = new ArrayList<>();

    public List<Socket> getClients() {
        return clients;
    }
    public List<Socket> getConnectedSockets() {
        return connectedSockets;
    }

    public ClientManager() {
        //startHeartbeatTimerTask(2000);
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

    private void startHeartbeatTimerTask(int interval) {
        Timer timer = new Timer();
        TimerTask heartbeatTimerTask = new HeartbeatTimerTask(this);

        timer.schedule(heartbeatTimerTask,0, interval);
    }
}
