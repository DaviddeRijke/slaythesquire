using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "Effects/Equipment")]
public class Equipment : ScriptableObject {
	public EquipmentSlot equipmentSlot;
	public int armor;
	public int damage;
}

public enum EquipmentSlot { head, body, legs, mainHand, offHand }
