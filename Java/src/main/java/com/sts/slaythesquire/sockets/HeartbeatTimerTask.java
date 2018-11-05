package com.sts.slaythesquire.sockets;

import java.net.Socket;
import java.util.ArrayList;
import java.util.List;
import java.util.TimerTask;

public class HeartbeatTimerTask extends TimerTask {

    private ClientManager manager;

    public HeartbeatTimerTask(ClientManager manager) {
        this.manager = manager;
    }

    @Override
    public void run() {
        List<Socket> socketsToRemove = new ArrayList<>();

        List<Socket> sockets = manager.getClients();
        List<Socket> connectedSockets = manager.getConnectedSockets();
        for (Socket s : sockets) {
            if (connectedSockets.contains(s))
                socketsToRemove.add(s);
        }

        for (Socket s : socketsToRemove) {
            manager.removeClient(s);
        }

        manager.getConnectedSockets().clear();
    }
}
