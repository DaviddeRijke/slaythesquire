using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMovement : MonoBehaviour {
    public Animator ani;
    public VisualEffectsController vfx;
    public FloatingCanvas floatingNumbers;
    public KeyCode key;
    private bool isInAction;

	// Use this for initialization
	void Start () {
        ani = gameObject.GetComponent<Animator>();
        isInAction = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayDuckAnimation();
        }
        if (Input.GetKeyDown(key))
        {
            PlayAttackAnimation(25);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            PlayForfeitAnimation();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayHealAnimation(15);
        }
    }

    public float PlayAttackAnimation(int damage)
    {
        PlayAnimation(Attack(damage));
        return 2.8f;
    }

    public float PlayDuckAnimation()
    {
        PlayAnimation(Duck());
        return 0.9f;
    }

    public void PlayHealAnimation(int hp)
    {
        PlayAnimation(Heal(hp));
    }

    public void PlayForfeitAnimation()
    {
        PlayAnimation(Forfeit());
    }

    public void PlayAnimation(IEnumerator animation)
    {
        if (!isInAction)
        {
            StartCoroutine(animation);
        }
    }

    private void PlayBloodVisualEffects()
    {
        float x = this.gameObject.transform.position.x;
        float z = this.gameObject.transform.position.z;
        int direction = Mathf.RoundToInt(x / Mathf.Abs(x));
        Vector3 pos = new Vector3(x + (direction * 0.66f), 1.75f, z - 0.5f);
        //vfx.PlayEffect(visualEffectNames.bloodExplosion, pos);
        //vfx.PlayEffect(visualEffectNames.bloodAndGutsExplosion, pos);
        vfx.PlayEffect(visualEffectNames.bloodFountain, pos);
    }

    private void PlayHealVisualEffects()
    {
        float x = this.gameObject.transform.position.x;
        float z = this.gameObject.transform.position.z;
        int direction = -1 * (Mathf.RoundToInt(x / Mathf.Abs(x)));
        Vector3 pos = new Vector3(x + (direction * 0.4f), 1f, z - 0.5f);
        vfx.PlayEffect(visualEffectNames.magicLightColumn, pos);
        vfx.PlayEffect(visualEffectNames.magicLightShining, pos);
    }

    private IEnumerator Attack(int damage)
    {
        isInAction = true;

        Vector3 position = this.gameObject.transform.position;
        Quaternion rotation = this.gameObject.transform.rotation;

        //Run forward forward and start attacking (1s)
        ani.SetFloat("Forward", 1);
        yield return new WaitForSeconds(0.593f * 2 *.6f);
        ani.SetBool("Attack", true);
        yield return new WaitForSeconds(0.593f * 2 * .4f);
        ani.SetFloat("Forward", 0);
        ani.SetBool("Attack", false);
        yield return new WaitForSeconds(0.2f);
        if (damage > 0)
        {
            floatingNumbers.ShowDamage(damage);

            PlayBloodVisualEffects();
        }
        else
        {
            floatingNumbers.ShowBlocking();
        }
        yield return new WaitForSeconds(1.5f);


        //Turn around (1.233 s)
        ani.SetFloat("Turn", 1);
        yield return new WaitForSeconds(1.233f / 2);
        ani.SetFloat("Turn", 0);
        transform.LookAt(position);

        //Run back (1s)
        ani.SetFloat("Forward", 1);
        yield return new WaitForSeconds(0.593f);
        transform.LookAt(position);

        //Since animation based movement is apparently not really precise, here we compensate for that:
        float distance = Mathf.Abs(Vector3.Distance(gameObject.transform.position, position));
        yield return new WaitForSeconds(distance * 0.2f);
        ani.SetFloat("Forward", 0);

        //Turn around (1.233 s)
        ani.SetFloat("Turn", -1);
        yield return new WaitForSeconds(1.233f / 2);
        ani.SetFloat("Turn", 0);

        this.gameObject.transform.position = position;
        this.gameObject.transform.rotation = rotation;

        isInAction = false;
    }

    public IEnumerator Duck()
    {
        isInAction = true;
        ani.SetBool("Crouch", true);
        yield return new WaitForSeconds(2f);
        ani.SetBool("Crouch", false);
        isInAction = false;
    }

    public IEnumerator Heal(int hp)
    {
        isInAction = true;
        ani.SetBool("Heal", true);
        yield return new WaitForSeconds(0.4f);
        PlayHealVisualEffects();
        floatingNumbers.ShowHealing(hp);
        yield return new WaitForSeconds(0.4f);
        ani.SetBool("Heal", false);
        isInAction = false;
    }

    public IEnumerator Forfeit()
    {
        isInAction = true;
        ani.SetFloat("Turn", -1);
        yield return new WaitForSeconds(1.233f / 2f);
        ani.SetFloat("Turn", 0);
        ani.SetFloat("Forward", 1);
        yield return new WaitForSeconds(4);
        ani.SetFloat("Forward", 0);
        isInAction = false;
    }
}