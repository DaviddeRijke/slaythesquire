﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMovement : MonoBehaviour {
    public Animator ani;
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
            PlayAttackAnimation();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            PlayForfeitAnimation();
        }
    }

    public void PlayAttackAnimation()
    {
        PlayAnimation(Attack());
    }

    public void PlayDuckAnimation()
    {
        PlayAnimation(Duck());
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


    private IEnumerator Attack()
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
        yield return new WaitForSeconds(3.4f / 2);
        

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