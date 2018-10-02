using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager _instance;
    private Turn turnManager;
    public bool CanPlay;

    public Text PhaseText;
    
	void Start () {
        _instance = this;
        CanPlay = false;
        turnManager = GetComponent<Turn>();
	}
	
	// Update is called once per frame
	void Update () {
        turnManager.Execute();
	}

    public void SetPhaseText(string phaseText)
    {
        PhaseText.text = phaseText;
    }
}
