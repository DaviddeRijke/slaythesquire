package com.sts.slaythesquire;

import com.sts.slaythesquire.controllers.PlayerController;
import com.sts.slaythesquire.matchmaking.MatchmakingPool;
import com.sts.slaythesquire.matchmaking.matchmakers.RandomMatchmaker;
import com.sts.slaythesquire.sockets.ClientManager;
import com.sts.slaythesquire.sockets.MessageHandler;
import com.sts.slaythesquire.sockets.ServerSocketListener;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.io.IOException;
import java.net.ServerSocket;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

@SpringBootApplication
public class Application implements CommandLineRunner {

    private ExecutorService pool = Executors.newFixedThreadPool(1);

    @Autowired
    PlayerController playerController;

    public static void main(String[] args) {
        SpringApplication.run(Application.class, args);
    }

    @Override
    public void run(String... args) {
        MatchmakingPool matchmakingPool = new MatchmakingPool(new RandomMatchmaker(), 10000, 20000);

        try {
            //pool.submit(new ServerSocketListener(new ServerSocket(4343,10), playerController.getPlayerRepository()));


            pool.submit(new ServerSocketListener(new ServerSocket(4343,10), new ClientManager(playerController.getPlayerRepository(), matchmakingPool)));
        } catch (IOException e) {
            e.printStackTrace();
        }

        //playerController.setMatchmakingPool(matchmakingPool);
    }
}
