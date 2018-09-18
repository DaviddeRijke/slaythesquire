package com.sts.slaythesquire.repos;

import com.sts.slaythesquire.models.Card;
import org.springframework.data.repository.CrudRepository;

import java.util.Collection;

public interface CardRepository extends CrudRepository<Card, Integer> {
    boolean existsByName(String name);
    Card findByName(String name);
    Card findById(int id);
    Collection<Card> findAll();
}
