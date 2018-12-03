using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Resolve;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectDamage", menuName = "Effects/Damage")]
public class EffectDamage : Effect, IBlockable {

	public int amount;

	public override void Activate(Knight target)
	{
		int totalArmor = 0;
		foreach (Equipment equipment in target.equipped)
		{
			totalArmor += equipment.armor;
		}
		target.RemoveHealth( (amount / 100) * (100 - totalArmor) );
	}

	public void Block()
	{
		throw new System.NotImplementedException();
	}
}
