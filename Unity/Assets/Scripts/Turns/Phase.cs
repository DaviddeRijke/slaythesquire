using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Phase : ScriptableObject {

    public bool forceExit = false;
    protected bool isInit = false;

    public abstract bool isComplete();

    public abstract void OnStartPhase();
    public abstract void OnEndPhase();

}
