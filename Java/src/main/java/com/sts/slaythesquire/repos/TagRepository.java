package com.sts.slaythesquire.repos;

import com.sts.slaythesquire.models.Card;
import com.sts.slaythesquire.models.Tag;
import org.springframework.data.repository.CrudRepository;

import java.util.Collection;

public interface TagRepository extends CrudRepository<Tag, Integer> {
    boolean existsByName(String name);
    Collection<Tag> findAll();
}
