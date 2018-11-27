using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectDamage", menuName = "Effects/Damage")]
public class EffectDamage : Effect {

	public int amount;

	public override void Activate(Knight target)
	{
		target.health -= amount;
	}
}
