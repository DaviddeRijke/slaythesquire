package com.sts.slaythesquire.matchmaking.matchmakers;

import com.sts.slaythesquire.matchmaking.IMatchmaker;
import com.sts.slaythesquire.matchmaking.MatchmakingPool;
import com.sts.slaythesquire.models.Match;
import com.sts.slaythesquire.models.Player;

import java.util.LinkedList;
import java.util.List;

public class RandomMatchmaker implements IMatchmaker {
    @Override
    public List<Match> makeMatches(List<Player> unmatchedPlayers, MatchmakingPool pool) throws InterruptedException {

        //System.out.println("making matches...");

        List<Player> matchedPlayers = new LinkedList<>();
        List<Match> newMatches = new LinkedList<>();

        Player player1 = null;

        for (Player player : unmatchedPlayers){
            if (player1 == null){
                player1 = player;
            } else{
                Match m = new Match(player1, player);
                matchedPlayers.add(player1);
                matchedPlayers.add(player);
                player1 = null;
                newMatches.add(m);
            }
        }

        pool.removePlayersFromPool(matchedPlayers);

        return newMatches;
    }
}
