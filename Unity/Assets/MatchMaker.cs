using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchMaker : MonoBehaviour
{
    public int playerId = 1;

    private MatchMakerScreen matchMakerScreen;
    private SceneManager sceneManager;

    private MatchmakingCommunicator matchmakingCommunicator;
    private GameCommunicator gameCommunicator;

    void Start()
    {
        matchMakerScreen = GetComponent<MatchMakerScreen>();
        sceneManager = GetComponent<SceneManager>();
        matchmakingCommunicator = DDOLAccesser.GetObject().GetComponent<MatchmakingCommunicator>();
        gameCommunicator = DDOLAccesser.GetObject().GetComponent<GameCommunicator>();
    }

    public void ConnectToServer()
    {
        //TODO: Get playerid from somewhere
        matchmakingCommunicator.ConnectToServer(playerId);
        matchmakingCommunicator.OnJoinedMatchmaking.AddListener(StartMatchMaking);
        matchmakingCommunicator.OnMatchedWithPlayer.AddListener(ConfirmMatch);
    }

    private void StartMatchMaking()
    {
        matchMakerScreen.StartMatchMaking();
    }

    private void ConfirmMatch(int playerId)
    {
        gameCommunicator.OwnPlayerId = this.playerId;
        gameCommunicator.OpponentPlayerId = playerId;
        //TODO: Keep track of matched playerId
        sceneManager.SwitchScene(2);
    }
}
