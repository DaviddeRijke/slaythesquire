using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardView3D : MonoBehaviour {

    public Card card;
    public TMPro.TextMeshProUGUI cost;
    public TMPro.TextMeshProUGUI title;
    public TMPro.TextMeshProUGUI description;
    public Material picture;

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
        this.title.SetText(card.title);
        this.description.SetText(card.description);
        this.picture.mainTexture = Resources.Load<Texture>("CardPictures/CardPlaceholder");
    }
}