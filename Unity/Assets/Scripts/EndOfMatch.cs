using System.Collections;
using System.Collections.Generic;
using Api;
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
	    RestController.Instance.Post("/match/add", new MatchResult(player.players[0], null));
        ToggleUI(win);
    }

	[System.Serializable]
	private struct MatchResult
	{
		public Player winner;
		public Player loser;

		public MatchResult(Player w, Player l)
		{
			winner = w;
			loser = l;
		}
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
	    SetRating(state ? 25 : -25);
		//SetRating( <<<APICALL NAAR NIEUWE RATING>>> );
    }

	public void SetGold(int additionalAmount)
	{
		goldAddition.text = "+ " + additionalAmount;
		goldResult.text = "= " + (player.players[0].currency + additionalAmount);

		goldChanged.Invoke(additionalAmount);
	}

	public void SetRating(int additionalAmount)
	{
		scoreAddition.text = "+ " + additionalAmount;
		scoreResult.text = "= " + (player.players[0].eloScore + additionalAmount);

		ratingChanged.Invoke(additionalAmount);
	}

	[System.Serializable]
	public class ValueChanged : UnityEvent<int> { }
}
