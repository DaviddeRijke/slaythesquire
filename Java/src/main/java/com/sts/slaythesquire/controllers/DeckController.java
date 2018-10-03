package com.sts.slaythesquire.controllers;

import com.sts.slaythesquire.models.Deck;
import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.repos.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.lang.NonNull;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.Collection;

@Controller
@RequestMapping(path= "api/deck")
public class DeckController {
    private final CardRepository cardRepository;
    private final DeckRepository deckRepository;
    private final PlayerRepository playerRepository;

    @Autowired
    public DeckController(final CardRepository cardRepository, final DeckRepository deckRepository, final PlayerRepository playerRepository){
        this.cardRepository = cardRepository;
        this.deckRepository = deckRepository;
        this.playerRepository = playerRepository;
    }

    @PostMapping(path= "/add")
    public @ResponseBody
        /// TODO: 2-10-2018 constraints
        boolean createDeckForPlayer(@RequestBody Deck deck){
        Player player = playerRepository.findById(deck.getPlayer().getId()).orElse(null);
        if(player == null){
            System.out.println("Player not found");
            return false;
        }
        deckRepository.save(deck);
        player.addDeck(deck);
        playerRepository.save(player);
        return deckRepository.existsById(deck.getId());
    }

    @GetMapping(path= "")
    public @ResponseBody
    Collection<Deck> getAllDecksForPlayer(final int playerId){
        return deckRepository.findAllByPlayer_Id(playerId);
    }
}
