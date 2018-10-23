package com.sts.slaythesquire.models;

import com.fasterxml.jackson.databind.annotation.JsonSerialize;
import com.sts.slaythesquire.utils.serializers.PlayerDeckSerializer;

import javax.persistence.*;
import java.util.List;

@Entity
public class Player {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    private String username;

    @Transient
    private Match match;

    public int getId(){
        return id;
    }

    public void setUsername(final String username){this.username = username;}
    public String getUsername(){
        return username;
    }

    @JsonSerialize(using = PlayerDeckSerializer.class)
    @OneToMany(cascade= CascadeType.ALL)
    @JoinTable(name="player_deck", joinColumns = @JoinColumn(name="player_id"))
    private List<Deck> decks;

    public List<Deck> getDecks() { return decks; }
    public void setDecks(List<Deck> decks) { this.decks = decks; }
    public void addDeck(Deck deck){
        decks.add(deck);
    }

    public Match getMatch() {
        return match;
    }

    public void setMatch(Match match) {
        this.match = match;
    }
}
