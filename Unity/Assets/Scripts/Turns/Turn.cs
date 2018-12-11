using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.Events;

public class Turn : MonoBehaviour {

    public Phase[] phases;
    public int index = 0;
    public int turnCount = 1;
	public EnergyRenew energyRenew;

	void Start()
    {
        GameManager._instance.SetPhaseText(phases[index].name);
    }

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
                turnCount++;
                completed = true;
				energyRenew.Invoke(0);
            }

            GameManager._instance.SetPhaseText(phases[index].name);
        }

        return completed;
    }

    public void ForcePhaseExit()
    {
        phases[index].forceExit = true;
    }

	[System.Serializable]
	public class EnergyRenew : UnityEvent<float> { }
}
