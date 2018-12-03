package com.sts.slaythesquire.utils;

import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.repos.PlayerRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.LinkedList;

@Service
public class ServerStartTestConfig {

    PlayerRepository playerRepository;

    @Autowired
    public ServerStartTestConfig(PlayerRepository playerRepository) {
        this.playerRepository = playerRepository;
    }

    public void init(){

        playerRepository.save(createPlayer("Piet"));
        playerRepository.save(createPlayer("Henk"));
        playerRepository.save(createPlayer("Mark"));
    }

    private Player createPlayer(String name){
        Player p1 = new Player();
        p1.setUsername(name);
        p1.setDecks(new LinkedList<>());
        return p1;
    }
}
