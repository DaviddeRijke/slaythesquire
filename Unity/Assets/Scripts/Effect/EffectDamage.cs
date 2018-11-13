using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectDamage", menuName = "ScriptableObjects/EffectDamage")]
public class EffectDamage : Effect {

	public int amount;

	public override void Activate(Knight self, Knight opponent)
	{
		opponent.hp -= amount;
	}
}
