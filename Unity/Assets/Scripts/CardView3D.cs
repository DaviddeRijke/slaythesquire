using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardView3D : MonoBehaviour {

    public Card card;
    
    public TMPro.TextMeshPro cost;
    public TMPro.TextMeshPro title;
    public TMPro.TextMeshPro description;
    public MeshRenderer picture;

    private void Awake()
    {
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void initCard(Card c)
    {
        this.card = c;
        this.cost.SetText(card.cost.ToString());
        this.title.SetText(card.name);
        this.description.SetText(card.description);
    }
}