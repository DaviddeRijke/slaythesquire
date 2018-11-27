using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectHeal", menuName = "Effects/Heal")]
public class EffectHeal : Effect {

	public int amount;

	public override void Activate(Knight target)
	{
		target.health += amount;
	}
}
