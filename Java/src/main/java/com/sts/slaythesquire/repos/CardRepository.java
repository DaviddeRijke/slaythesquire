package com.sts.slaythesquire.repos;

import com.sts.slaythesquire.models.Card;
import org.springframework.data.repository.CrudRepository;

public interface CardRepository extends CrudRepository<Card, Integer> {
    boolean existsByName(String name);
}
