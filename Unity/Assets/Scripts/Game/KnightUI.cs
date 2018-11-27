using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnightUI : MonoBehaviour {
    public string knightName;
    public float hp = 100;
    private float initialHp;
    public Text nameText;
    public Text healthText;
    public Image healthBar;
    public Gradient healthTextColor;
    public Gradient healthBarColor;

	// Use this for initialization
	void Start () {
        //TODO: Get Knight name
        SetName(knightName);

        SetHealth(hp);
        initialHp = hp;
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
}
