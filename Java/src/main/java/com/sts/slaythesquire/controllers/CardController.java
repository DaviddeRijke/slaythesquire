package com.sts.slaythesquire.controllers;

import com.sts.slaythesquire.models.Card;
import com.sts.slaythesquire.models.Effect;
import com.sts.slaythesquire.models.EndTurnAction;
import com.sts.slaythesquire.models.Tag;
import com.sts.slaythesquire.repos.CardRepository;
import com.sts.slaythesquire.repos.EffectRepository;
import com.sts.slaythesquire.repos.EndTurnActionRepository;
import com.sts.slaythesquire.repos.TagRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.lang.NonNull;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.Collection;

@Controller
@RequestMapping(path= "/api/cards")
public class CardController {
    private final CardRepository cardRepository;
    private final TagRepository tagRepository;
    private final EffectRepository effectRepository;
    private final EndTurnActionRepository endTurnActionRepository;

    @Autowired
    public CardController(final CardRepository cardRepository, final TagRepository tagRepository, final EffectRepository effectRepository, final EndTurnActionRepository endTurnActionRepository){
        this.cardRepository = cardRepository;
        this.tagRepository = tagRepository;
        this.effectRepository = effectRepository;
        this.endTurnActionRepository = endTurnActionRepository;
    }

    @GetMapping(path="")
    public @ResponseBody
    Collection<Card> getCards(){
        return cardRepository.findAll();
    }

    @GetMapping(path="/get")
    public @ResponseBody Card getCard(@NonNull int id){
        return cardRepository.findById(id);
    }

    @DeleteMapping(path="/remove")
    public @ResponseBody boolean removeCard(@RequestBody final Card card){
        cardRepository.delete(card);
        return !cardRepository.existsByName(card.getName());
    }

    @PostMapping(path="/add")
    public @ResponseBody boolean addCard(@RequestBody final Card card) {
        if (card == null) throw new IllegalArgumentException("The card is not allowed to be null.");
        for(Tag tag : card.getTags()){
            if(!tagRepository.existsById(tag.getId())) tagRepository.save(tag);
        }
        for(Effect effect : card.getEffects()){
            if(!effectRepository.existsById(effect.getId())) effectRepository.save(effect);
        }
        if(!endTurnActionRepository.existsById(card.getEndTurnAction().getId())) endTurnActionRepository.save(card.getEndTurnAction());
        cardRepository.save(card);
        return cardRepository.existsByName(card.getName());
    }
}
