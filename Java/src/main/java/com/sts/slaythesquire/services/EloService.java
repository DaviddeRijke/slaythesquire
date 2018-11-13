package com.sts.slaythesquire.services;
import com.sts.slaythesquire.models.Player;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class EloService{

    private PlayerService playerService;

    @Autowired
    public EloService(PlayerService playerService){
        this.playerService = playerService;
    }

    public void changeElo(Player winner, Player loser){
        int normal = 25;
        int low = 15;
        int high = 35;

        int winnerElo = winner.getEloScore();
        int loserElo = loser.getEloScore();

        winner.changeEloScore(winnerElo > loserElo ? low : high);
        loser.changeEloScore(winnerElo > loserElo ? low : high);

    }
}
