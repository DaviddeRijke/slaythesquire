using System.Collections;
using System.Collections.Generic;
using Resolve;
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

        self.gameObject.GetComponent<KnightMovement>().PlayAttackAnimation();
        if (amount > 0)
        {
            opponent.RemoveHealth(Mathf.RoundToInt(((amount + totalDamage) / 100f) * (100f - totalArmor)));
        }
        else
        {
            //Blocked
        }
		opponent.RemoveHealth( Mathf.RoundToInt(((amount + self.GetDamage()) / 100f) * (100f - opponent.GetArmor())) );
	}

	public void Block()
	{
        this.amount = 0;
	}
}