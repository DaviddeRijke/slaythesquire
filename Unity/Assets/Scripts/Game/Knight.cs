using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Knight : MonoBehaviour {
	public int health;
	public List<Equipment> equipped;
    public ValueChanged healthChanged;
    public UnityEvent death;
    public EquipmentChanged equipChanged;

    private void Start()
    {
        equipped = new List<Equipment>();
    }

    public void AddHealth(int amount)
    {
		health = Mathf.Min(health + amount, 100);
        healthChanged.Invoke(health);
    }

    public void RemoveHealth(int amount)
    {
        health -= Mathf.Abs(amount);
        if (health <= 0)
        {
            health = 0;
            death.Invoke();
        }
        healthChanged.Invoke(health);
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
        equipChanged.Invoke(equipment);
	}

	public int GetDamage()
	{
		int totalDamage = 0;
		foreach (Equipment equipment in this.equipped)
		{
			totalDamage += equipment.damage;
		}
		return totalDamage;
	}

	public int GetArmor()
	{
		int totalArmor = 0;
		foreach (Equipment equipment in this.equipped)
		{
			totalArmor += equipment.armor;
		}
		return totalArmor;
	}

	[System.Serializable]
	public class ValueChanged : UnityEvent<float> { }

    [System.Serializable]
    public class EquipmentChanged : UnityEvent<Equipment> { }
}
