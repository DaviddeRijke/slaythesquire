using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

[Serializable]
public class Player {
	public int id;
	public string username;
	//string match, placeholder
	//public string[] decks; //placeholder
	public Deck[] decks;
	public int currency;
	public int eloScore;
}
