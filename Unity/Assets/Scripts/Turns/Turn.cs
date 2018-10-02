using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour {

    public Phase[] phases;
    public int index = 0;

    public bool Execute()
    {
        bool completed = false;

        phases[index].OnStartPhase();

        bool phaseIsComplete = phases[index].isComplete();

        if (phaseIsComplete)
        {
            phases[index].OnEndPhase();

            index++;
            if (index > phases.Length - 1)
            {
                index = 0;
                completed = true;
            }
        }

        return completed;
    }

}
