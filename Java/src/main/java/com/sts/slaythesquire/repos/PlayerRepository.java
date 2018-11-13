package com.sts.slaythesquire.repos;

import com.sts.slaythesquire.models.Player;
import org.springframework.data.repository.CrudRepository;

import java.util.Collection;

public interface PlayerRepository extends CrudRepository<Player, Integer> {
    Collection<Player> findAll();

    Player findFirstByUsername(String username);

}
