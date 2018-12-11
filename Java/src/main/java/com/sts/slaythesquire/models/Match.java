package com.sts.slaythesquire.models;

import com.sts.slaythesquire.sockets.DelegateAction;
import com.sts.slaythesquire.sockets.Packet;

import java.util.Timer;
import java.util.TimerTask;

public class Match {

    private Player firstPlayer;
    private Player secondPlayer;

    private boolean firstPlayerConfirmed = false;
    private boolean secondPlayerConfirmed = false;

    private boolean firstPlayerEndedTurn = false;
    private boolean secondPlayerEndedTurn = false;

    private int turnCount = 0;

    private Packet firstPlayerResolvePacket = null;
    private Packet secondPlayerResolvePacket = null;

    private Packet firstPlayerStatusPacket = null;
    private Packet secondPlayerStatusPacket = null;

    private TimerTask turnTimerTask;
    private Timer turnTimer;

    private Long turnTime = 30000L;

    public Match(Player firstPlayer, Player secondPlayer) {
        this.firstPlayer = firstPlayer;
        this.secondPlayer = secondPlayer;

        turnTimer = new Timer();

        preMatchPreparation(this.firstPlayer);
        preMatchPreparation(this.secondPlayer);

        Packet packet = new Packet();

        packet.setAction("MATCHED");

        packet.addProperty("playerId", Integer.toString(secondPlayer.getId()));
        this.firstPlayer.sendPacket(packet);

        packet.overrideProperty("playerId", Integer.toString(firstPlayer.getId()));
        this.secondPlayer.sendPacket(packet);
    }

    private void preMatchPreparation(Player player){
        player.getMessageHandler().subscribe("CONFIRMMATCH", p -> {
            playerConfirmed(player);
        });

        player.getMessageHandler().subscribe("PLAYEDCARD", playerPlayedCardAction(player));
        player.getMessageHandler().subscribe("ENDTURN", playerEndedTurn(player));
        player.getMessageHandler().subscribe("CARDSPLAYED", playerPlayedTurnAction(player));
        player.getMessageHandler().subscribe("STATUS", playerSendsStatus(player));

    }

    private void startNewRound(){
        Packet packet = new Packet();
        packet.setAction("PLAYPHASE");
        packet.addProperty("turnCount", Integer.toString(turnCount));

        sendToBoth(packet);

        System.out.println("Started new round, starting timer...");

        turnTimerTask = new TimerTask() {
            @Override
            public void run() {
                System.out.println("Ending turn...");
                playersEndedTurn();
            }
        };

        turnTimer.schedule(turnTimerTask, turnTime);

    }

    private DelegateAction playerEndedTurn(Player player){
        return p -> {
            if (player.getId() == firstPlayer.getId()){
                firstPlayerEndedTurn = true;
            }

            if (player.getId() == secondPlayer.getId()){
                secondPlayerEndedTurn = true;
            }

            if (firstPlayerEndedTurn && secondPlayerEndedTurn){

                playersEndedTurn();

            }

        };
    }

    private synchronized void playersEndedTurn(){

        if (turnTimerTask != null){
            turnTimerTask.cancel();
            turnTimerTask =null;
        }

        Packet p = new Packet();
        p.setAction("ENDTURN");

        sendToBoth(p);

        firstPlayerEndedTurn = false;
        secondPlayerEndedTurn = false;

    }

    private DelegateAction playerPlayedCardAction(Player player){
        return p -> {
            int playedCard = Integer.parseInt(p.getProperty("card"));

            Packet packet = new Packet();
            packet.setAction("PLAYEDCARD");
            System.out.println("Played card");

            sendToOtherPlayer(player, packet);

        };
    }

    private DelegateAction playerPlayedTurnAction(Player player){
        return p -> {

            Packet newPacket = new Packet();
            newPacket.setAction("RESOLVEPHASE");

            newPacket.setProperties(p.getProperties());

            setResolvePacketForPlayer(player, newPacket);

        };
    }

    private DelegateAction playerSendsStatus(Player player){
        return p -> setStatusForPlayer(player, p);
    }

    private void setResolvePacketForPlayer(Player player, Packet packet){

        if (player.getId() == firstPlayer.getId()){
            firstPlayerResolvePacket = packet;
        }

        if (player.getId() == secondPlayer.getId()){
            secondPlayerResolvePacket = packet;
        }

        if (firstPlayerResolvePacket != null && secondPlayerResolvePacket != null){
            sendToOtherPlayer(firstPlayer, firstPlayerResolvePacket);
            sendToOtherPlayer(secondPlayer, secondPlayerResolvePacket);

            firstPlayerResolvePacket = null;
            secondPlayerResolvePacket = null;

        }

    }

    private void setStatusForPlayer(Player player, Packet status){
        if (player.getId() == firstPlayer.getId()){
            firstPlayerStatusPacket = status;
        }

        if (player.getId() == secondPlayer.getId()){
            secondPlayerStatusPacket = status;
        }

        if (firstPlayerStatusPacket != null && secondPlayerStatusPacket != null){

            checkStatus();

            firstPlayerStatusPacket = null;
            secondPlayerStatusPacket = null;

        }

    }

    private void checkStatus(){
        
        if (!firstPlayerStatusPacket.getProperty("data").equals(secondPlayerStatusPacket.getProperty("data"))
                || !firstPlayerStatusPacket.getProperty("winner").equals(secondPlayerStatusPacket.getProperty("winner"))) {
            //void
            declareVoid();
            return;
        }

        int winnerId = 0;

        try{
            winnerId = Integer.parseInt(firstPlayerStatusPacket.getProperty("winner"));
        }catch (Exception e){
            e.printStackTrace();
        }

        if (winnerId == 0){
            turnCount++;
            startNewRound();
        } else{
            declareWinner(winnerId);
        }

    }

    private void declareVoid(){
        Packet p = new Packet();
        p.setAction("MATCHVOID");

        sendToBoth(p);
    }

    private void declareWinner(int winnerId){

        Packet p = new Packet();
        p.setAction("WINNER");
        p.addProperty("playerId", winnerId);

        sendToBoth(p);
    }


    private void sendToBoth(Packet p){
        firstPlayer.sendPacket(p);
        secondPlayer.sendPacket(p);
    }

    private void playerConfirmed(Player player){
        if (player.getId() == firstPlayer.getId()){
            firstPlayerConfirmed = true;
        }
        if (player.getId() == secondPlayer.getId()){
            secondPlayerConfirmed = true;
        }

        if (firstPlayerConfirmed && secondPlayerConfirmed){
            startNewRound();
        }

    }

    private void sendToOtherPlayer(Player sender, Packet packet){
        Player other = getOtherPlayer(sender);
        if (other == null){
            //???????
            return;
        }

        other.sendPacket(packet);

    }

    private Player getOtherPlayer(Player thisPlayer){
        if (thisPlayer.getId() == firstPlayer.getId()){
            return secondPlayer;
        } else if (thisPlayer.getId() == secondPlayer.getId()){
            return firstPlayer;
        }
        return null;
    }

    public Match(){}
}
