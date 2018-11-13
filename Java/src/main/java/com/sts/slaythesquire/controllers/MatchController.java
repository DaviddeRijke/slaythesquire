package com.sts.slaythesquire.controllers;

import com.sts.slaythesquire.models.MatchResult;
import com.sts.slaythesquire.models.Player;
import com.sts.slaythesquire.repos.PlayerRepository;
import com.sts.slaythesquire.services.EloService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

import java.util.ArrayList;
import java.util.List;

@Controller
@RequestMapping(path="api/match")
public class MatchController{
        private final PlayerRepository playerRepository;
        private final EloService eloService;

        @Autowired
        public MatchController(final PlayerRepository playerRepository, final EloService eloService){
            this.playerRepository = playerRepository;
            this.eloService = eloService;
        }

        @PostMapping(path="/add")
        public @ResponseBody
        boolean addMatch(@RequestBody final MatchResult match) {
            System.out.println("Receiving match");
            System.out.println(match.getWinner());
            System.out.println(match.getLoser());
            Player winner = playerRepository.findById(match.getWinner().getId()).orElse(null);
            Player loser = playerRepository.findById(match.getLoser().getId()).orElse(null);
            if(winner == loser) System.out.println("HOUSTON WE GOT A PROBLEM");
            if(winner == null) winner = loser;
            if(loser == null) loser = winner;

            System.out.println(match);
            eloService.changeElo(winner, loser);

            return playerRepository.save(winner) != null
                    && playerRepository.save(loser) != null;
        }
}
