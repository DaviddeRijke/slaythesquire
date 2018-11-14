package com.sts.slaythesquire.sockets;

import java.io.IOException;
import java.io.OutputStream;
import java.net.Socket;
import java.util.*;

public class MessageHandler {

    private Socket socket;

    private Map<String, List<DelegateAction>> topics;

    public MessageHandler(Socket socket) {
        this.socket = socket;

        topics = new LinkedHashMap<>();
        /*
        subscibe("CONNECT", packet -> {
            System.out.println(packet.getAction());
        });
        */
    }

    public void subscribe(String topic, DelegateAction action){
        if (!topics.containsKey(topic)){
            topics.put(topic, new LinkedList<>());
        }
        topics.get(topic).add(action);
    }

    public void unsubscribe(String topic){
        //how?
    }

    public void handleMessage(Packet packet) {
        System.out.println("Handling packet...");
        if (topics.containsKey(packet.getAction())){
            for (DelegateAction action : topics.get(packet.getAction())){
                System.out.println("Invoking...");
                action.invoke(packet);
            }
        }else {
            //does not contain key
            System.out.println("Nothing subscribed to: " + packet.getAction());
        }
        /*
        if (packet.getAction().equals("HEARTBEAT")) {
            //clientManager.keepAlive(packet.getClient());
        }
        else if (packet.getAction().equals("CONNECT")) {
            connect(packet);
        }
        else if (packet.getAction().equals("DISCONNECT")) {
            disconnect(packet.getClient());
        }
        else if (packet.getAction().equals("TESTMOVE")) {
            //testMove(packet);
        }
        else if (packet.getAction().equals("STARTMATCHMAKING")){

            //joinMatchmaking(packet);

        }
        else {
            Packet p = new Packet(packet.getClient(), "ERROR/No valid function");
            sendPacket(p);
        }*/
    }

    public Socket getSocket() {
        return socket;
    }

    /*private void joinMatchmaking(Packet packet){
        int id = -1;

        try{
            id = Integer.parseInt(packet.getArgs()[0].trim());

        }catch(NumberFormatException e){
            e.printStackTrace();
        }

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

        //p.setSocket(packet.getClient());

        System.out.println("adding " + p.getUsername() + " to matchmaking pool.");
        clientManager.addPlayerToMatchmaking(p);


    }*/

    /*
    public void disconnect(Socket socket) {
        try {
            clientManager.removeClient(socket);
            socket.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }*/

    /*
    private void connect(Packet packet) {
        clientManager.addClient(packet.getClient());

        Packet response = new Packet(packet.getClient(), "OkConnect/Connected");
        sendPacket(response);
    }*/

    public void sendPacket(Packet packet) {
        try {
            OutputStream os = socket.getOutputStream();
            String toSend = packet.getMessage();
            byte[] toSendBytes = toSend.getBytes();

            System.out.println("Sending message: " + toSend);

            os.write(toSendBytes);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    /*private void testMove(final Packet packet) {
        Timer timer = new Timer();
        TimerTask timerTask = new TimerTask() {
            @Override
            public void run() {
                Packet moveCommand = new Packet(packet.getClient(), "MOVE/0.1");
                sendPacket(moveCommand);
            }
        };

        timer.schedule(timerTask,0, 200);
    }*/

}
