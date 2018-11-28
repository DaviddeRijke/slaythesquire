package com.sts.slaythesquire.sockets;

import com.google.gson.Gson;
import com.sts.slaythesquire.models.Card;

import java.util.ArrayList;
import java.util.List;

public class JsonConverter {

    private static Gson gson = new Gson();

    public static List<Card> cardListFromJson(List<String> jsonList) {
        List<Card> cards = new ArrayList<>();
        for (String json : jsonList) {
            cards.add(gson.fromJson(json, Card.class));
        }
        return cards;
    }

    public static List<String> cardListToJson(List<Card> cards) {
        List<String> jsonList = new ArrayList<>();
        for (Card card : cards) {
            jsonList.add(gson.toJson(card));
        }
        return jsonList;
    }

    public static Card cardFromJson(String json) {
        return gson.fromJson(json, Card.class);
    }

    public static String cardToJson(Card card) {
        return gson.toJson(card);
    }
}
