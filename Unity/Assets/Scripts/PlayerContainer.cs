using Api;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Container", menuName = "CardContainer")]
public class PlayerContainer : ScriptableObject, ILoadable
{
	public List<Player> Players;

	public void SetData<T>(T[] entities)
	{
		if (!(entities is Player[]))
		{
			Debug.Log("Data invalid");
			return;
		}

		Players = (entities as Player[]).ToList();

	}
}
