package com.sts.slaythesquire.sockets;

public class Packet {

    private String action;
    private String[] args;

    public String getAction() {
        return action;
    }
    public String[] getArgs() {
        return args;
    }

    public Packet(String message) {

        String[] packet = message.split("/");
        action = packet[0].toUpperCase().trim();
        if (packet.length > 1)
        args = new String[packet.length - 1];
        for (int i = 0; i < packet.length - 1; i++) {
            args[i] = packet[i + 1];
        }
    }

    public String getMessage() {
        StringBuilder message = new StringBuilder(action);
        if (args != null)
            for (String arg : args) {
                message.append("/").append(arg);
            }
        return message.toString();
    }
}
