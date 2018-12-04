using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Resolve;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectDamage", menuName = "Effects/Damage")]
public class EffectDamage : Effect, IBlockable {

	public int amount;

	public override void Activate(Knight self, Knight opponent)
	{
		int totalDamage = 0;
		foreach (Equipment equipment in self.equipped)
		{
			totalDamage += equipment.damage;
		}
		int totalArmor = 0;
		foreach (Equipment equipment in opponent.equipped)
		{
			totalArmor += equipment.armor;
		}
		opponent.RemoveHealth( Mathf.RoundToInt(((amount + totalDamage) / 100f) * (100f - totalArmor)) );
	}

	public void Block()
	{
		throw new System.NotImplementedException();
	}
}
