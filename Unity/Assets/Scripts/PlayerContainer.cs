using Api;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Container", menuName = "PlayerContainer")]
public class PlayerContainer : ScriptableObject, ILoadable
{
	public List<Player> players;

	public void SetData<T>(T[] entities)
	{
		if (!(entities is Player[]))
		{
			Debug.Log("Data invalid");
			return;
		}

		players = (entities as Player[]).ToList();

	}
}
