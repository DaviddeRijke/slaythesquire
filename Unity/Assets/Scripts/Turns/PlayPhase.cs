using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayPhase", menuName = "Phases/PlayPhase")]
public class PlayPhase : Phase
{
    private int round = 0;

    public override bool isComplete()
    {
        if (forceExit)
        {
            forceExit = false;
            return true;
        }

        return false;
    }

    public override void OnEndPhase()
    {
        if (isInit)
        {
            isInit = false;
            GameManager._instance.AcceptCardInput = false;
        }
    }

    public override void OnStartPhase()
    {
        if (!isInit)
        {
            isInit = true;
            GameManager._instance.AcceptCardInput = true;

            ++round;
            Splash.instance.SetRoundNumber(round);
            Splash.instance.StartSplash();

            // TODO: Call Effect.BeforeTurn()
            // TODO: Draw Card(s)
            // TODO: Call Effect.OnDrawCard()
        }
    }
}
