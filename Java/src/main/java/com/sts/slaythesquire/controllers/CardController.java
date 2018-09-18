package com.sts.slaythesquire.controllers;

import com.sts.slaythesquire.models.Card;
import com.sts.slaythesquire.repos.CardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.lang.NonNull;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

@Controller
@RequestMapping(path= "/api/cards")
public class CardController {

    private final CardRepository cardRepository;

    @Autowired
    public CardController(final CardRepository cardRepository){this.cardRepository = cardRepository;}

    @PostMapping(path="/addCard")
    public @ResponseBody
    boolean addCard(@RequestBody final Card card) {
        if (card == null) throw new IllegalArgumentException("The card is not allowed to be null.");
        cardRepository.save(card);
        return cardRepository.existsByName(card.getName());
    }

}
