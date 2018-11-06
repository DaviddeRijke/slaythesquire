package com.sts.slaythesquire.models;

import javax.persistence.*;

@Entity
public class MatchResult {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    @ManyToOne
    private Player winner;
    @ManyToOne
    private Player loser;
    //to add: date

    public Player getWinner(){
        return winner;
    }

    public MatchResult(){}

    public Player getLoser(){
        return loser;
    }
    public void setWinner(Player player) {winner = player;}
    public void setLoser(Player player) {loser = player;}

}
