package com.sts.slaythesquire.models;

import javax.persistence.*;

@Entity
public class Effect {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    private String name;

    public int getId(){
        return id;
    }

    public void setName(final String name){this.name = name;}
    public String getName(){
        return name;
    }
}
