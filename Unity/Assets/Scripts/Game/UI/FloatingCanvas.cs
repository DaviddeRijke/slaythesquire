using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingCanvas : MonoBehaviour {
    public Text damageText;
    public Text healText;
    public Text blockedText;
    private Animator ani;

	// Use this for initialization
	void Start () {
        ani = this.gameObject.GetComponent<Animator>();
	}
	
	public void ShowDamage(int amount)
    {
        damageText.text = "-" + amount.ToString();
        StartCoroutine(StartAnimationByName("Damage"));
    }

    public void ShowHealing(int amount)
    {
        healText.text = "+" + amount.ToString();
        StartCoroutine(StartAnimationByName("Heal"));
    }

    public void ShowBlocking()
    {
        StartCoroutine(StartAnimationByName("Block"));
    }

    private IEnumerator StartAnimationByName(string animation)
    {
        ani.SetBool(animation, true);
        yield return new WaitForSeconds(0.1f);
        ani.SetBool(animation, false);
    }
}
