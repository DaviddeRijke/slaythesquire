package com.sts.slaythesquire.controllers;

import com.sts.slaythesquire.matchmaking.MatchmakingPool;
import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.repos.CardRepository;
import com.sts.slaythesquire.repos.DeckRepository;
import com.sts.slaythesquire.repos.PlayerRepository;
import com.sts.slaythesquire.sockets.Packet;
import com.sts.slaythesquire.utils.serializers.IntegerWrapper;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.lang.NonNull;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.Collection;

@Controller
@RequestMapping(path= "/api/players")
public class PlayerController {
    private final PlayerRepository playerRepository;

    public PlayerRepository getPlayerRepository() {
        return playerRepository;
    }

    //private MatchmakingPool matchmakingPool;

    //public void setMatchmakingPool(MatchmakingPool matchmakingPool){
        //this.matchmakingPool = matchmakingPool;
    //}

    @Autowired
    public PlayerController(final PlayerRepository playerRepository){
        this.playerRepository = playerRepository;
    }

    @GetMapping(path= "/all")
    public @ResponseBody
    Collection<Player> getPlayers(){
        return playerRepository.findAll();
    }

    @RequestMapping(path= "/{userId}", method = RequestMethod.GET)
    public @ResponseBody
    Collection<Player> player(@PathVariable(value = "userId") int id){
        Collection<Player> players = new ArrayList<>();
        ((ArrayList<Player>) players).add(playerRepository.findById(id).orElse(null));
        if (((ArrayList<Player>) players).get(0) == null) throw new NullPointerException("The player is not allowed to be null.");
        return players;
    }

    /*@RequestMapping(path= "/message/{userId}/{message}", method = RequestMethod.GET)
    public @ResponseBody
    boolean messagePlayer(@PathVariable(value = "userId") int id, @PathVariable(value = "message") String message){

        Player p = matchmakingPool.getPlayerById(id);
        if (p == null){
            return false;
        }

        p.sendPacket(new Packet("MESSAGE/" + message));

        return true;
    }*/

    @PostMapping(path= "/add")
    public @ResponseBody
    boolean addPlayer(@RequestBody Player player){
        /// TODO: 2-10-2018 add constraints
        playerRepository.save(player);
        return playerRepository.existsById(player.getId());
    }

    @RequestMapping(path= "/{userId}/changecurrency", method = RequestMethod.PUT)
    public @ResponseBody
    boolean changeCurrency(
            @PathVariable(value = "userId") int user,
            @RequestBody IntegerWrapper amount){
        System.out.println(amount);
        System.out.println(amount.getValue());
        Player player = playerRepository.findById(user).orElse(null);
        if(player == null){
            System.out.println("Player not found");
            return false;
        }
        player.changeCurrency(amount.getValue());
        playerRepository.save(player);
        return true;
    }
}
