package com.sts.slaythesquire.controllers;

import com.sts.slaythesquire.models.Card;
import com.sts.slaythesquire.repos.CardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.Collection;

@Controller
@RequestMapping(path= "/api/cards")
public class CardController {
    private final CardRepository cardRepository;

    @Autowired
    public CardController(final CardRepository cardRepository){
        this.cardRepository = cardRepository;
    }

    @GetMapping(path="")
    public @ResponseBody
    Collection<Card> getCards(){
        return cardRepository.findAll();
    }

    @DeleteMapping(path="/removeCard")
    public @ResponseBody boolean removeProduct(@RequestBody final Card card){
        cardRepository.delete(card);
        return !cardRepository.existsByName(card.getName());
    }

    @PostMapping(path="/addCard")
    public @ResponseBody boolean addCard(@RequestBody final Card card) {
        if (card == null) throw new IllegalArgumentException("The card is not allowed to be null.");
        cardRepository.save(card);
        return cardRepository.existsByName(card.getName());
    }

}
