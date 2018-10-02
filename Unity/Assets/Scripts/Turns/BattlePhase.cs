using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BattlePhase", menuName = "Phases/BattlePhase")]
public class BattlePhase : Phase
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
            // TODO: Call Effect.AfterBattle()
        }
    }

    public override void OnStartPhase()
    {
        if (!isInit)
        {
            isInit = true;
            // TODO: Call Effect.BeforeBattle()
            // TODO: Call Effect.OnBattle()
        }
    }
}
