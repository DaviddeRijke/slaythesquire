using System.Collections;
using System.Collections.Generic;
using Resolve;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectHeal", menuName = "Effects/Heal")]
public class EffectHeal : Effect, INoInteraction {

	public int amount;

	public override void Activate(Knight self, Knight opponent)
	{
        self.gameObject.GetComponent<KnightMovement>().PlayHealAnimation(amount);
        self.AddHealth(amount);
	}
}
