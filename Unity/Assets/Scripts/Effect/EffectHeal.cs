using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectHeal", menuName = "ScriptableObjects/EffectHeal")]
public class EffectHeal : Effect {

	public int amount;

	public override void Activate(Knight self, Knight opponent)
	{
		self.hp += amount;
	}
}
