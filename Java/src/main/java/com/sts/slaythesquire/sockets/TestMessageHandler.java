package com.sts.slaythesquire.sockets;

import java.util.LinkedHashMap;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;

public class TestMessageHandler {
/*

    Map<String, List<DelegateAction>> topics;

    public TestMessageHandler() {

        topics = new LinkedHashMap<>();

        //Dit kan overal in je code staan. Je kunt dus on demand subscriben
        subscibe("DoeEenZet", packet -> {

        });

    }


    public void handleMessage(Packet packet) {

        if (topics.containsKey(packet.getFunction())){
            for (DelegateAction action : topics.get(packet.getFunction())){
                action.invoke(packet);
            }
        }
    }

    public void subscibe(String topic, DelegateAction action){
        if (!topics.containsKey(topic)){
            topics.put(topic, new LinkedList<>());
        }
        topics.get(topic).add(action);
    }


    private interface DelegateAction{

        void invoke(Packet packet);

    }*/
}
