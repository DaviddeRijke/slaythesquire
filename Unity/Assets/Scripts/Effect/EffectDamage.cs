using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Resolve;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectDamage", menuName = "Effects/Damage")]
public class EffectDamage : Effect, IBlockable {

	public int amount;

	public override void Activate(Knight self, Knight opponent)
	{
		opponent.RemoveHealth( Mathf.RoundToInt(((amount + self.GetDamage()) / 100f) * (100f - opponent.GetArmor())) );
	}

	public void Block()
	{
		throw new System.NotImplementedException();
	}
}
