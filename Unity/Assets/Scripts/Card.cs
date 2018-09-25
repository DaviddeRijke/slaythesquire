﻿using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Card : MonoBehaviour {

    public GameObject titleObject;
    public GameObject descriptionObject;
    public GameObject pictureObject;
    public GameObject costObject;
    public Api api;

    public int id;
    public string title;
    public string description;
    public Material picture;
    public int cost;
    public List<Effect> effects;

    void Start () {
        IDictionary<string, object> json = api.GetCardById(this.id);
        this.title = json["name"].ToString();
        this.description = json["description"].ToString();
        this.picture = (Material)AssetDatabase.LoadAssetAtPath("Assets/Materials/CardPictures/" + this.title + ".mat", typeof(Material));
        this.cost = Convert.ToInt32(json["cost"]);
        //todo: add effects from database

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
    }
}
