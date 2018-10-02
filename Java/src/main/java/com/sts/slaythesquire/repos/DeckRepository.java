package com.sts.slaythesquire.repos;

import com.sts.slaythesquire.models.Deck;
import org.springframework.data.repository.CrudRepository;

import java.util.Collection;

public interface DeckRepository extends CrudRepository<Deck, Integer> {
    Collection<Deck> findAllByPlayer_Id(int id);
}
