﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnightUI : MonoBehaviour {
	public Knight knight;
	public string knightName;
    public float hp = 100;
    private float initialHp;
	public float energy = 10;
	private float initialEnergy;
    public Text nameText;
    public Text healthText;
	public Text energyText;
    public Image healthBar;
	public Image energyBar;
	public Gradient healthTextColor;
    public Gradient healthBarColor;
	public Gradient energyTextColor;
	public Gradient energyBarColor;
	public Button equipmentButton;
    public GameObject equipmentPanel;
    public EquipmentSlotUI[] equipment;
    public Text totalDamageText;
    private int totalDamage;
    public Text totalArmorText;
    private int totalArmor;
    public Sprite emptySlotImage;
    private Animator ani;
    private bool collapse;


	// Use this for initialization
	void Start () {
        //TODO: Get Knight name
        SetName(knightName);

        SetHealth(hp);
        initialHp = hp;

		SetEnergy(energy);
		initialEnergy = energy;

		SetTotalsUI();

        collapse = false;
        ani = equipmentPanel.GetComponent<Animator>();
	}

    public void SetName(string newName)
    {
        if (newName != null && newName.Length > 0)
        {
            knightName = newName;
            nameText.text = knightName;
        }
    }
	
	public void SetHealth(float newHP)
    {
        hp = newHP;
        float relative = hp / initialHp;
        healthText.text = Mathf.RoundToInt(hp).ToString();
        healthBar.fillAmount = relative;

        healthText.color = healthTextColor.Evaluate(1 - relative);
        healthBar.color = healthBarColor.Evaluate(1 - relative);
    }

	public void SetEnergy(float newEnergy)
	{
		energy = newEnergy;
		float relative = energy / initialEnergy;
		energyText.text = Mathf.RoundToInt(energy).ToString();
		energyBar.fillAmount = relative;

		energyText.color = energyTextColor.Evaluate(1 - relative);
		energyBar.color = energyBarColor.Evaluate(1 - relative);
	}

	private void SetTotalsUI()
    {
		totalArmor = knight.GetArmor();
		totalDamage = knight.GetDamage();
		totalDamageText.text = "+" + totalDamage.ToString();
        totalArmorText.text = totalArmor.ToString() + "%";
    }

    public void ToggleEquipmentPanel()
    {
        if (collapse)
        {
            collapse = false;
            equipmentButton.GetComponentInChildren<Text>().text = "Hide Equipment";
        }
        else
        {
            collapse = true;
            equipmentButton.GetComponentInChildren<Text>().text = "Show Equipment";
        }
        ani.SetBool("Collapse", collapse);
    }

    public void EquipItem(Equipment item)
    {
		equipment[((int)item.equipmentSlot)].SetData(item);
        SetTotalsUI();
    }

    [System.Serializable]
    public struct EquipmentSlotUI
    {
        public Image image;
        public Text stat;

        public void SetData(Equipment e)
        {
            image.sprite = e.image;

            if (e.equipmentSlot == EquipmentSlot.mainHand)
            {
                stat.text = "+ " + e.damage.ToString();
            }
            else
            {
                stat.text = "+ " + e.armor.ToString();
            }
        }

        public void ResetData()
        {
            image.sprite = Resources.Load<Sprite>("Sprite/Equipment/Nothing");
            stat.text = "+ 0";
        }
    }
}
