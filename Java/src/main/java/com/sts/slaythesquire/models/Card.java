package com.sts.slaythesquire.models;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Card {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;

    private String name;

    public void setId(final int id){
        this.id = id;
    }

    public int getId(){
        return id;
    }

    public void setName(final String name){
        this.name = name;
    }

    public String getName(){
        return name;
    }
}
