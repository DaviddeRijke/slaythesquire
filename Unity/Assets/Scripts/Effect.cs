using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect : ScriptableObject {
    
    public int speed;

    public virtual string getDescription()
    {
        return "";
    }

    public virtual void Apply() { }
}
