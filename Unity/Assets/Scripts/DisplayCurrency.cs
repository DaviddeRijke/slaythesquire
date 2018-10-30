﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCurrency : MonoBehaviour {

	public PlayerContainer playerContainer;
	public Text textObject;

	public void SetCurrency()
	{
		textObject.text = playerContainer.players[0].currency.ToString();
	}
}