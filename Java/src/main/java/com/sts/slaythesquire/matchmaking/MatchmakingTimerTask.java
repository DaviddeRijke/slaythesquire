package com.sts.slaythesquire.matchmaking;

import java.util.TimerTask;

public class MatchmakingTimerTask extends TimerTask {

    private MatchmakingPool matchmakingPool;

    public MatchmakingTimerTask(MatchmakingPool matchmakingPool) {
        this.matchmakingPool = matchmakingPool;
    }

    @Override
    public void run() {
        try {
            matchmakingPool.createMatches();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
