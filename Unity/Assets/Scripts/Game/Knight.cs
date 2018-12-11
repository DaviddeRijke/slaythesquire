using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Knight : MonoBehaviour {
	public int health;
	public int maxHealth;
	public int energy;
	public int maxEnergy;
	public List<Equipment> equipped;
    public HealthChanged healthChanged;
	public EnergyChanged energyChanged;
    public UnityEvent death;
    public EquipmentChanged equipChanged;

    private void Start()
    {
        equipped = new List<Equipment>();
    }

    public void AddHealth(int amount)
    {
		health = Mathf.Min(health + amount, maxHealth);
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

	public void AddEnergy(int amount)
	{
		energy = Mathf.Min(energy + amount, maxEnergy);
		energyChanged.Invoke(energy);
	}

	public void RemoveEnergy(int amount)
	{
		energy -= Mathf.Abs(amount);
		energyChanged.Invoke(energy);
	}

	public void RenewEnergy()
	{
		energy = maxEnergy;
		energyChanged.Invoke(energy);
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
	public class HealthChanged : UnityEvent<float> { }

	[System.Serializable]
	public class EnergyChanged : UnityEvent<float> { }

	[System.Serializable]
    public class EquipmentChanged : UnityEvent<Equipment> { }
}
