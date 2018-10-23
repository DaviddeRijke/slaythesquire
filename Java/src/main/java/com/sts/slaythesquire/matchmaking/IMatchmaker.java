package com.sts.slaythesquire.matchmaking;

import com.sts.slaythesquire.models.Match;
import com.sts.slaythesquire.models.Player;

import java.util.List;

public interface IMatchmaker {

    /**
     * Creates a list of new matches made from the passed unmatched players.
     * Whenever a match is found, a new match object should be made, added to the players,
     * and the players should be removed from the matchmaking pool.
     *
     * @param unmatchedPlayers      A list of unmatched players.
     * @param pool                  The matchmaking pool
     * @return                      The list of new matches
     * @throws InterruptedException When a function on the matchmaking pool throws the error
     */
    List<Match> makeMatches(List<Player> unmatchedPlayers, MatchmakingPool pool) throws InterruptedException;

}
