using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectDamage", menuName = "Effects/Damage")]
public class EffectDamage : Effect {

	public int amount;

	public override void Activate(Knight target)
	{
		int totalArmor = 0;
		foreach (Equipment equipment in target.equipped)
		{
			totalArmor += equipment.armor;
		}
		target.health -= (amount / 100) * (100 - totalArmor);
	}
}
