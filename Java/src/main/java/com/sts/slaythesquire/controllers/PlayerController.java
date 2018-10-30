package com.sts.slaythesquire.controllers;

import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.repos.CardRepository;
import com.sts.slaythesquire.repos.DeckRepository;
import com.sts.slaythesquire.repos.PlayerRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.Collection;

@Controller
@RequestMapping(path= "/api/players")
public class PlayerController {
    private final PlayerRepository playerRepository;

    @Autowired
    public PlayerController(final PlayerRepository playerRepository){
        this.playerRepository = playerRepository;
    }

    @GetMapping(path= "/all")
    public @ResponseBody
    Collection<Player> getPlayers(){
        return playerRepository.findAll();
    }

    @GetMapping(path= "")
    public @ResponseBody
    Player player(@RequestParam int id){
        Player player = playerRepository.findById(id).orElse(null);
        if (player == null) throw new NullPointerException("The player is not allowed to be null.");
        return player;
    }

    @PostMapping(path= "/add")
    public @ResponseBody
    boolean addPlayer(@RequestBody Player player){
        /// TODO: 2-10-2018 add constraints
        playerRepository.save(player);
        return playerRepository.existsById(player.getId());
    }

    @PatchMapping(path= "/changecurrency")
    public @ResponseBody
    boolean changeCurrency(@RequestParam int id, int amount){
        Player player = playerRepository.findById(id).orElse(null);
        if(player == null){
            System.out.println("Player not found");
            return false;
        }
        player.changeCurrency(amount);
        playerRepository.save(player);
        return true;
    }
}
