package com.sts.slaythesquire.utils.serializers;

import com.fasterxml.jackson.core.JsonGenerator;
import com.fasterxml.jackson.databind.SerializerProvider;
import com.fasterxml.jackson.databind.ser.std.StdSerializer;
import com.sts.slaythesquire.models.Deck;
import com.sts.slaythesquire.models.Player;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class PlayerDeckSerializer extends StdSerializer<List<Deck>> {
    public PlayerDeckSerializer() {
        this(null);
    }

    public PlayerDeckSerializer(final Class<List<Deck>> t) {
        super(t);
    }

    @Override
    public void serialize(
            final List<Deck> items,
            final JsonGenerator generator,
            final SerializerProvider provider)
            throws IOException
    {
        List<Deck> decks = new ArrayList<>();
        for(Deck item : items){
            item.getPlayer().setDecks(null);
            decks.add(item);
        }
        generator.writeObject(decks);
    }
}
