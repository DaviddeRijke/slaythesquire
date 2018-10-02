using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DrawPhase", menuName = "Phases/DrawPhase")]
public class DrawPhase : Phase
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

            GameManager._instance.DrawCards();

            // TODO: Call Effect.BeforeTurn()
            // TODO: Draw Card(s)
            // TODO: Call Effect.OnDrawCard()
        }
    }
}
