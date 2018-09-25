using Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

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
        //todo: useable url
        StartCoroutine(GetRequest(""));

        this.titleObject.GetComponent<TMPro.TextMeshPro>().text = this.title;
        this.descriptionObject.GetComponent<TMPro.TextMeshPro>().text = this.description;
        this.pictureObject.GetComponent<Renderer>().material = this.picture;
        this.costObject.GetComponent<TMPro.TextMeshPro>().text = this.cost.ToString();
    }

    void Activate()
    {
        //todo: make card do something when played
    }

    IEnumerator GetRequest(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            var values = JsonParser.FromJson(uwr.downloadHandler.text);
            //todo: use values to fill fields
            //use name to find path for picture
            Debug.Log(values.ToString());
        }
    }
}
