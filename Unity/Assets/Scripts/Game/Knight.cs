using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Knight : MonoBehaviour {
	public int health;
	public List<Equipment> equipped;

	public Knight()
	{
		equipped = new List<Equipment>();
	}

	public void Equip(Equipment equipment)
	{
		foreach (Equipment item in equipped)
		{
			if (item.equipmentSlot == equipment.equipmentSlot)
			{
				equipped.Remove(item);
				break;
			}
		}
		equipped.Add(equipment);
	}

	[System.Serializable]
	public class ValueChanged : UnityEvent<int> { }
}
