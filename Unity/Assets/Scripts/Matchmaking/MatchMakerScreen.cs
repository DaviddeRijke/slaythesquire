using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchMakerScreen : MonoBehaviour {
    public GameObject[] objectsToHide;
    public GameObject[] objectsToShow;

    public void ToggleUI(bool showMatchmaking)
    {
        foreach (GameObject obj in objectsToHide)
        {
            obj.SetActive(!showMatchmaking);
        }

        foreach (GameObject obj in objectsToShow)
        {
            obj.SetActive(showMatchmaking);
        }


    }
}
