package com.sts.slaythesquire.sockets;

import java.net.Socket;

public class Packet {

    private Socket clientSocket;
    private String function;
    private String[] args;

    public Socket getClient() {
        return clientSocket;
    }
    public String getFunction() {
        return function;
    }
    public String[] getArgs() {
        return args;
    }

    public Packet(Socket clientSocket, String message) {
        this.clientSocket = clientSocket;

        String[] packet = message.split("/");
        function = packet[0].toUpperCase().trim();
        if (packet.length > 1)
        args = new String[packet.length - 1];
        for (int i = 0; i < packet.length - 1; i++) {
            args[i] = packet[i + 1];
        }
    }

    public String getMessage() {
        String message = function;
        if (args != null)
            for (String arg : args) {
                message += "/" + arg;
            }
        return message;
    }
}
