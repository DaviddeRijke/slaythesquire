using System.Collections;
using System.Collections.Generic;
using DefaultNamespace.Resolve;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectDamage", menuName = "Effects/Damage")]
public class EffectDamage : Effect, IBlockable {

	public int amount;

	public override void Activate(Knight target)
	{
		target.health -= amount;
	}

	public void Block()
	{
		throw new System.NotImplementedException();
	}
}
