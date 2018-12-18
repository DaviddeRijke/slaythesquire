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
    }

    public void subscribe(String topic, DelegateAction action){
        if (!topics.containsKey(topic)){
            topics.put(topic, new LinkedList<>());
        }
        topics.get(topic).add(action);
    }

    public void unsubscribe(String topic){
        topics.remove(topic);
        //TODO:how?
    }

    public void handleMessage(Packet packet) {
        if (topics.containsKey(packet.getAction())){
            for (DelegateAction action : topics.get(packet.getAction())){
                System.out.println("Invoking: " + packet.getAction());
                action.invoke(packet);
            }
        } else {
            //does not contain key
            System.out.println("Nothing subscribed to: " + packet.getAction());
        }
    }

    public Socket getSocket() {
        return socket;
    }

    public void sendPacket(Packet packet) {
        try {
            OutputStream os = socket.getOutputStream();
            String toSend = packet.getMessage();
            byte[] toSendBytes = toSend.getBytes();

            System.out.println("Sending message: " + toSend);

//            int toSendLength = toSendBytes.length;
//            byte[] toSendLenBytes = new byte[4];
//            toSendLenBytes[0] = (byte)(toSendLength & 0xff);
//            toSendLenBytes[1] = (byte)((toSendLength >> 8) & 0xff);
//            toSendLenBytes[2] = (byte)((toSendLength >> 16) & 0xff);
//            toSendLenBytes[3] = (byte)((toSendLength >> 24) & 0xff);
//
//            os.write(toSendLenBytes);
            os.write(toSendBytes);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
