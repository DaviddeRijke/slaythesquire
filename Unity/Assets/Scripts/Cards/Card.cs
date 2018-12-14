using System;
using System.Collections.Generic;
using Api;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
[CreateAssetMenu(fileName = "Card", menuName = "Card")]
public class Card : ScriptableObject{
    public int id;
    public string name;
    public string description;
    public int cost;
    public Tag[] tags;
    public Effect[] effects;
    public EndTurnAction endTurnAction;

    public UnityEvent OnEnable;
    public UnityEvent OnDisable;

    public void Activate(Knight self, Knight opponent)
    {
        foreach(Effect effect in effects)
        {
            effect.Activate(self, opponent);
        }
    }

    public void Enable()
    {
        OnEnable.Invoke();
    }

    public void Disable()
    {
        OnDisable.Invoke();
    }
}