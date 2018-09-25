using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEditor;
using UnityEngine;

public class Card : MonoBehaviour {

    public GameObject titleObject;
    public GameObject descriptionObject;
    public GameObject pictureObject;
    public GameObject costObject;

    public int id;
    public string title;
    public string description;
    public Material picture;
    public int cost;
    public List<Effect> effects;

	void Start () {
        this.titleObject.GetComponent<TMPro.TextMeshPro>().text = this.title;
        this.descriptionObject.GetComponent<TMPro.TextMeshPro>().text = this.description;
        this.pictureObject.GetComponent<Renderer>().material = this.picture;
        this.costObject.GetComponent<TMPro.TextMeshPro>().text = this.cost.ToString();
    }

    public void Activate()
    {
        foreach(Effect effect in effects)
        {
            effect.Activate();
        }
        // TODO: make card do something when played
    }
}
