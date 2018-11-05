using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EndOfMatch : MonoBehaviour {
	public PlayerContainer player;

	public GameObject[] objectsToHide;
    public GameObject[] objectsToShow;
    public GameObject winText;
    public GameObject loseText;
    public Text scoreAddition;
    public Text scoreResult;
    public Text goldAddition;
    public Text goldResult;

	public ValueChanged goldChanged;
	public ValueChanged ratingChanged;

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

		int newGold = 10;

        if (state)
        {
            winText.SetActive(true);
			newGold += 15;
        }
        else
        {
            loseText.SetActive(true);
        }

		SetGold(newGold);
		//SetRating( <<<APICALL NAAR NIEUWE RATING>>> );
    }

	public void SetGold(int additionalAmount)
	{
		goldAddition.text = "+ " + additionalAmount;
		goldResult.text = "= " + (player.players[0].currency + additionalAmount);

		goldChanged.Invoke(additionalAmount);
	}

	public void SetRating(int additionalRating)
	{
		//scoreAddition.text = "+ " + additionalAmount;
		//scoreResult.text = "= " + (player.players[0] + additionalAmount);

		//ratingChanged.Invoke(additionalAmount);
	}

	[System.Serializable]
	public class ValueChanged : UnityEvent<int> { }
}
