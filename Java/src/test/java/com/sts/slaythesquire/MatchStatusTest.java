package com.sts.slaythesquire;

import com.google.gson.Gson;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import org.junit.Test;

public class MatchStatusTest {

    private int i = 0;

    @Test
    public void testIntParse(){

        JsonObject containerJson = new Gson().toJsonTree(new IntContainer(1)).getAsJsonObject();
        containerJson.addProperty("a", Integer.toString(2));

        System.out.println(containerJson);

        i = Integer.parseInt(containerJson.get("a").getAsString());

        System.out.println(i);

    }

    private class IntContainer{
        private int i;

        public IntContainer(int i) {
            this.i = i;
        }

        public int getI() {
            return i;
        }

        public void setI(int i) {
            this.i = i;
        }
    }

}
