package com.sts.slaythesquire.matchmaking;

import com.sts.slaythesquire.models.Match;
import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.utils.threading.ReadWriteMonitor;

import java.util.*;

public class MatchmakingPool {

    private List<Player> unmatchedPlayers;
    private List<Match> matches;

    private IMatchmaker matchmaker;

    private ReadWriteMonitor playerMonitor;
    private ReadWriteMonitor matchMonitor;

    private Timer timer;

    public MatchmakingPool(IMatchmaker matchmaker, int timerStartDelay, int timerPeriod) {

        this.matchmaker = matchmaker;

        unmatchedPlayers = new LinkedList<>();
        matches = new LinkedList<>();
        timer = new Timer();

        playerMonitor = new ReadWriteMonitor();
        matchMonitor = new ReadWriteMonitor();

        timer.schedule(new MatchmakingTimerTask(this), timerStartDelay, timerPeriod);

    }

    public void createMatches() throws InterruptedException {

        List<Match> newMatches = matchmaker.makeMatches(getUnmatchedPlayers(), this);

        matchMonitor.enterWriter();

        matches.addAll(newMatches);

        matchMonitor.exitWriter();
    }

    public void removePlayerFromPool(Player player) throws InterruptedException {
        playerMonitor.enterWriter();

        unmatchedPlayers.remove(player);

        playerMonitor.exitWriter();
    }

    public void removePlayersFromPool(List<Player> players) throws InterruptedException {
        playerMonitor.enterWriter();

        unmatchedPlayers.removeAll(players);

        playerMonitor.exitWriter();
    }

    public void addPlayerToPool(Player player) throws InterruptedException {
        playerMonitor.enterWriter();

        unmatchedPlayers.add(player);

        playerMonitor.exitWriter();
    }

    public void removeMatch(Match match) throws InterruptedException {
        matchMonitor.enterWriter();

        matches.remove(match);

        matchMonitor.exitWriter();
    }

    public List<Player> getUnmatchedPlayers() throws InterruptedException {
        List<Player> r = new ArrayList<>();

        playerMonitor.enterReader();

        Collections.copy(r, unmatchedPlayers);

        playerMonitor.exitReader();

        return r;
    }

    public List<Match> getMatches() throws InterruptedException {
        List<Match> r = new ArrayList<>();

        matchMonitor.enterReader();

        Collections.copy(r, matches);

        matchMonitor.exitReader();

        return r;
    }



}
