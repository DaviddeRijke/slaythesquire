using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Player {
	int id;
	string username;
	int currency;
	int elo;

	public int Id { get; set; }

	public string Username { get; set; }

	public int Currency { get; set; }

	public int Elo { get; set; }
}
