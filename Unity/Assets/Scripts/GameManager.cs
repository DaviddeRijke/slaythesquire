﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager _instance;
    private Turn turnManager;
    public Hand hand;
    public bool CanPlay;

    public Text PhaseText;
    
	void Awake () {
        _instance = this;
        CanPlay = false;
        turnManager = GetComponent<Turn>();
	}
	
	void Update () {
        turnManager.Execute();
	}

    public void SetPhaseText(string phaseText)
    {
        PhaseText.text = phaseText;
    }

    // TODO: Actually draw cards.
    public void DrawCards()
    {
        foreach(Transform card in hand.transform)
        {
            card.gameObject.SetActive(true);
        }
        hand.FitCards();
    }
}