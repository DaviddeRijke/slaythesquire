package com.sts.slaythesquire.sockets;

import com.google.gson.*;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Packet {

    private String action;
    private HashMap<String, String> properties = new HashMap<>(); // name, json

    /**
     * <summary>
     *     Use this for new Packets
     * </summary>
     */
    public Packet() {}

    /**
     * <summary>
     *     Use this for recieved Packets
     * </summary>
     * @param json The recieved json
     */
    public Packet(String json) {
        Gson gson = new Gson();
        JsonObject jsonObject = new JsonParser().parse(json.trim()).getAsJsonObject();

        action = gson.fromJson(jsonObject.get("action"), String.class);

        JsonObject props = jsonObject.getAsJsonObject("properties");
        if (props != null) {
            for (Map.Entry<String, JsonElement> entry : props.entrySet()) {
                properties.put(entry.getKey(), entry.getValue().getAsString());
            }
        }
    }

    /**
     *
     * @return Returns the json to send
     */
    public String getMessage() {
        JsonObject props = null;
        if (properties.size() > 0) {
            props = new JsonObject();
            for (Map.Entry<String, String> entry : properties.entrySet()) {
                props.addProperty(entry.getKey(), entry.getValue());
            }
        }

        JsonObject json = new JsonObject();
        json.addProperty("action", action);
        json.add("properties", props);

        return json.toString();
    }

    public void setAction(String action) {
        this.action = action.toUpperCase();
    }

    public String getAction() {
        return this.action;
    }

    public void overrideProperty(String property, String json) {
        removeProperty(property);
        addProperty(property, json);
    }

    public boolean addProperty(String property, String json) {
        if (properties.containsKey(property))
            return false;

        properties.put(property, json);
        return true;
    }

    public boolean addProperty(String property, int value){
        return addProperty(property, Integer.toString(value));
    }

    public boolean addArrayProperty(String property, List<String> jsonList) {
        if (properties.containsKey(property))
            return false;

        JsonArray array = new JsonArray();
        for (String json : jsonList) {
            array.add(json);
        }

        properties.put(property, array.toString());
        return true;
    }

    public boolean removeProperty(String property) {
        if (!properties.containsKey(property))
            return false;

        properties.remove(property);
        return true;
    }

    public String getProperty(String property) {
        if (!properties.containsKey(property))
            return null;

        return properties.get(property);
    }

    public List<String> getArrayProperty(String property) {
        if (!properties.containsKey(property))
            return null;

        List<String> jsonList = new ArrayList<>();

        JsonElement element = new JsonParser().parse(properties.get(property));
        JsonArray array = element.getAsJsonArray();
        for (JsonElement json : array) {
            jsonList.add(json.getAsString());
        }

        return jsonList;
    }

    public HashMap<String, String> getProperties() {
        return properties;
    }

    public void setProperties(HashMap<String, String> properties) {
        this.properties = properties;
    }
}
