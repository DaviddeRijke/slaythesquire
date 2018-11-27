package com.sts.slaythesquire.models;

import com.sts.slaythesquire.sockets.DelegateAction;
import com.sts.slaythesquire.sockets.Packet;

public class Match {

    private Player firstPlayer;
    private Player secondPlayer;

    private boolean firstPlayerConfirmed = false;
    private boolean secondPlayerConfirmed = false;

    private int turnCount = 0;

    Packet firstPlayerResolvePacket = null;
    Packet secondPlayerResolvePacket = null;

    public Match(Player firstPlayer, Player secondPlayer) {
        this.firstPlayer = firstPlayer;
        this.secondPlayer = secondPlayer;

        preMatchPreparation(this.firstPlayer);
        preMatchPreparation(this.secondPlayer);

        this.firstPlayer.sendPacket(new Packet("MATCHED/" + secondPlayer.getId()));
        this.secondPlayer.sendPacket(new Packet("MATCHED/" + firstPlayer.getId()));
    }

    private void preMatchPreparation(Player player){
        player.getMessageHandler().subscribe("CONFIRMMATCH", p -> {
            playerConfirmed(player);
            checkToStartMatch();
        });
    }

    private void checkToStartMatch(){
        if (!(firstPlayerConfirmed && secondPlayerConfirmed)){
            return;
        }



        sendToBoth(new Packet("PLAYPHASE/" + turnCount));

    }

    private DelegateAction playerPlayedCardAction(Player player){
        return p -> {
            int playedCard = Integer.parseInt(p.getArgs()[0].trim());

            sendToOtherPlayer(player, new Packet("PLAYEDCARD"));

        };
    }

    private DelegateAction playerPlayedTurnAction(Player player){
        return p -> {

            StringBuilder s = new StringBuilder().append(String.format("RESOLVEPHASE/%d", turnCount));

            for (String arg : p.getArgs()){
                s.append(String.format("/%s", arg));
            }



        };
    }

    private void setResolvePacketForPlayer(Player player, Packet packet){

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
