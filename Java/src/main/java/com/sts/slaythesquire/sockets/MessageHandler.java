package com.sts.slaythesquire.sockets;


import java.io.IOException;
import java.io.OutputStream;
import java.net.Socket;
import java.util.Timer;
import java.util.TimerTask;

public class MessageHandler {

    private ClientManager clientManager;

    public MessageHandler() {
        clientManager = new ClientManager();
    }

    public void handleMessage(Packet packet) {

        if (packet.getFunction().equals("HEARTBEAT")) {
            clientManager.keepAlive(packet.getClient());
        }
        else if (packet.getFunction().equals("CONNECT")) {
            connect(packet);
        }
        else if (packet.getFunction().equals("DISCONNECT")) {
            disconnect(packet.getClient());
        }
        else if (packet.getFunction().equals("TESTMOVE")) {
            testMove(packet);
        }
        else {
            Packet p = new Packet(packet.getClient(), "ERROR/No valid function");
            sendPacket(p);
        }
    }

    public void disconnect(Socket socket) {
        try {
            clientManager.removeClient(socket);
            socket.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private void connect(Packet packet) {
        clientManager.addClient(packet.getClient());

        Packet response = new Packet(packet.getClient(), "INFO/Connected");
        sendPacket(response);
    }

    private void sendPacket(Packet packet) {
        try {
            Socket clientSocket = packet.getClient();
            OutputStream os = clientSocket.getOutputStream();
            String toSend = packet.getMessage();
            byte[] toSendBytes = toSend.getBytes();

            os.write(toSendBytes);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private void testMove(final Packet packet) {
        Timer timer = new Timer();
        TimerTask timerTask = new TimerTask() {
            @Override
            public void run() {
                Packet moveCommand = new Packet(packet.getClient(), "MOVE/0.1");
                sendPacket(moveCommand);
            }
        };

        timer.schedule(timerTask,0, 200);
    }
}
