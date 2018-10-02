package com.sts.slaythesquire.models;

import javax.persistence.*;
import java.util.Collection;

@Entity
public class Deck {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    private String name;

    @ManyToMany(cascade=CascadeType.ALL)
    @JoinTable(name="deck_card", joinColumns = @JoinColumn(name="deck_id"))
    public Collection<Card> cards;

    public int getId(){
        return id;
    }

    public void setName(final String name){this.name = name;}
    public String getName(){
        return name;
    }
}
