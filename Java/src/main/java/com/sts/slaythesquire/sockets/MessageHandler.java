package com.sts.slaythesquire.sockets;


import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.repos.PlayerRepository;
import org.springframework.beans.factory.annotation.Autowired;

import java.io.IOException;
import java.io.OutputStream;
import java.net.Socket;
import java.util.*;

public class MessageHandler {

    private ClientManager clientManager;

    private static int dirtyIdHack = 1;

    private PlayerRepository playerRepository;

    //Map<String, List<DelegateAction>> topics;

    public MessageHandler(PlayerRepository playerRepository) {
        this.playerRepository = playerRepository;
        clientManager = new ClientManager();
/*
        topics = new LinkedHashMap<>();

        subscibe("CONNECT", packet -> {
            System.out.println(packet.getFunction());
        });
*/
    }
/*
    public void subscibe(String topic, DelegateAction action){
        if (!topics.containsKey(topic)){
            topics.put(topic, new LinkedList<>());
        }
        topics.get(topic).add(action);
    }
*/
    public void handleMessage(Packet packet) {
/*
        if (topics.containsKey(packet.getFunction())){
            for (DelegateAction action : topics.get(packet.getFunction())){
                action.invoke(packet);
            }
        }
*/
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
        else if (packet.getFunction().equals("STARTMATCHMAKING")){


            System.out.println("handling: " + packet.getMessage());
            joinMatchmaking(packet);

        }
        else {
            Packet p = new Packet(packet.getClient(), "ERROR/No valid function");
            sendPacket(p);
        }
    }

    private void joinMatchmaking(Packet packet){
        int id = -1;

        try{
            id = Integer.parseInt(packet.getArgs()[0].trim());

        }catch(NumberFormatException e){
            e.printStackTrace();
        }


        /*
        id = dirtyIdHack;
        dirtyIdHack++;
        if (dirtyIdHack > 2){
            dirtyIdHack = 1;
        }*/


        if(id == -1){
            System.out.println("id is wrong");
            return;
        }

        System.out.println("retrieving player");
        Player p = playerRepository.findById(id).orElse(null);

        if (p == null){
            System.out.println("player not found");
            return;
        }

        p.setSocket(packet.getClient());

        System.out.println("adding " + p.getUsername() + " to matchmaking pool.");
        clientManager.addPlayerToMatchmaking(p);


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

        Packet response = new Packet(packet.getClient(), "OkConnect/Connected");
        sendPacket(response);
    }

    public static void sendPacket(Packet packet) {
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

    private interface DelegateAction{

        void invoke(Packet packet);

    }

}
