using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour {

	public Api api;
	public GameObject card;

	private void Start()
	{
		GetAllCards();
	}

	List<GameObject> GetAllCards()
	{
		List<GameObject> cards = new List<GameObject>();
		foreach (int id in api.GetAllCardIds())
		{
			card.GetComponent<Card>().id = id;
			GameObject newCard = Instantiate(card);
			cards.Add(newCard);
		}
		return cards;
	}

	GameObject GetCardById(int id)
	{
		card.GetComponent<Card>().id = id;
		GameObject newCard = Instantiate(card);
		return newCard;
	}
}
