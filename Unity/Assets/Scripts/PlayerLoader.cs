using Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour {

	public PlayerContainer Container;

	public void GetAllPlayers()
	{
		RestController.Instance.Get<Player>("/players/all", Container);
	}

	public void GetPlayer(int id)
	{
		RestController.Instance.Get<Player>("/players/" + id, Container);
	}

	public void ChangeCurrency(int amount)
	{
		Container.players[0].currency += amount;
		RestController.Instance.Put("/players/" + Container.players[0].id + "/changecurrency/", amount);
	}
}
