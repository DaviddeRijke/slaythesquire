using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyUI : MonoBehaviour {

	public float energy = 10;
	private float initialEnergy;
	public Text energyText;
	public Image energyBar;
	public Gradient energyTextColor;
	public Gradient energyBarColor;

	public void Start()
	{
		SetEnergy(energy);
		initialEnergy = energy;
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
}
