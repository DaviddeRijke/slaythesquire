using System;
using System.Collections.Generic;
using Api;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Card {
    //public Api api;

    public int id;
    public string name;
    public string description;
    public int cost;
    public Tag[] tags;
    public Effect[] effects;
    public EndTurnAction endTurnAction;

    public UnityEvent OnEnable;
    public UnityEvent OnDisable;
    
    public void Activate()
    {
        foreach(Effect effect in effects)
        {
            effect.Activate();
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


    //test



}