﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectEquip", menuName = "Effects/Equip")]
public class EffectEquip : Effect {

	public Equipment equipment;

	public override void Activate(Knight self, Knight opponent)
	{
		self.Equip(equipment);
	}
}
