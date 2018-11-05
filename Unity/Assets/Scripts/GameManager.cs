using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager _instance;
    private Turn turnManager;
    public CardHolder hand;
    public bool CanPlay = false;

    public Text PhaseText;

    public Card CardToLoad;

	void Awake () {
        _instance = this;
        turnManager = GetComponent<Turn>();
	}

    //void Start()
    //{
    //    foreach (Transform card in hand.transform)
    //    {
    //        card.gameObject.GetComponent<CardView3D>().initCard(CardToLoad);
    //    }
    //}
	
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
