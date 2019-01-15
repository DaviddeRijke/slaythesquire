using System.Collections;
using System.Collections.Generic;
using Resolve;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectEquip", menuName = "Effects/Equip")]
public class EffectEquip : Effect, INoInteraction {

	public Equipment equipment;

	public override void Activate(Knight self, Knight opponent)
	{
		self.Equip(equipment);
	}
	
	public override float Duration()
	{
		return 1.5f;
	}
}
