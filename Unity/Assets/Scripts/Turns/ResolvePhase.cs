﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ResolvePhase", menuName = "Phases/ResolvePhase")]
public class ResolvePhase : Phase
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

        }
    }

    public override void OnStartPhase()
    {
        if (!isInit)
        {
            isInit = true;
            // TODO: Call Effect.OnEndTurn()
        }
    }
}
