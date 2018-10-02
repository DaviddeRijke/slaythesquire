using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MainPhase", menuName = "Phases/MainPhase")]
public class MainPhase : Phase
{
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
            GameManager._instance.CanPlay = false;
        }
    }

    public override void OnStartPhase()
    {
        if (!isInit)
        {
            isInit = true;
            GameManager._instance.CanPlay = true;
            // TODO: Call Effect.OnStartTurn()
        }
    }
}
