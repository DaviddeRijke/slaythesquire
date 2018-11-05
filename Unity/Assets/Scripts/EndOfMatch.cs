using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOfMatch : MonoBehaviour {
    public GameObject[] objectsToHide;
    public GameObject[] objectsToShow;
    public GameObject winText;
    public GameObject loseText;
    public Text scoreAddition;
    public Text scoreResult;
    public Text goldAddition;
    public Text goldResult;

    public void EndMatch()
    {
        bool win = System.Convert.ToBoolean(Random.Range(0, 2));

        ToggleUI(win);
    }

    private void ToggleUI(bool state)
    {
        foreach (GameObject obj in objectsToHide)
        {
            obj.SetActive(false);
        }

        foreach (GameObject obj in objectsToShow)
        {
            obj.SetActive(true);
        }

        if (state)
        {
            winText.SetActive(true);
        }
        else
        {
            loseText.SetActive(true);
        }
    }
}
