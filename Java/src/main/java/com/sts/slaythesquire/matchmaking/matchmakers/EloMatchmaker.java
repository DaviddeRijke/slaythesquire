package com.sts.slaythesquire.matchmaking.matchmakers;

import com.sts.slaythesquire.matchmaking.IMatchmaker;
import com.sts.slaythesquire.matchmaking.MatchmakingPool;
import com.sts.slaythesquire.models.Match;
import com.sts.slaythesquire.models.Player;

import java.util.LinkedList;
import java.util.List;

public class EloMatchmaker implements IMatchmaker {
    @Override
    public List<Match> makeMatches(List<Player> unmatchedPlayers, MatchmakingPool pool) {
        return new LinkedList<>();
    }
}
