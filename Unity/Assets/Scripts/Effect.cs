using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect : ScriptableObject {

    // Called on phases
    public virtual void BeforeTurn() { }
    public virtual void OnStartTurn() { }

    public virtual void BeforeActivate() { }
    public virtual void Activate() { } // Called when Card played
    public virtual void AfterActivate() { }

    public virtual void BeforeBattle() { }
    public virtual void OnBattle() { }
    public virtual void AfterBattle() { }

    public virtual void OnEndTurn() { }

    // Called on actions
    public virtual void OnDrawn() { }
    public virtual void OnDiscarded() { }
    public virtual void OnDrawCard() { }
    public virtual void OnDamageDealt() { }
    public virtual void OnDamageRecieved() { }
    public virtual void OnHealed() { }

}
