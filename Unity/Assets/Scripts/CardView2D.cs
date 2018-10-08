using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CardView2D : MonoBehaviour {

    public Card card;
	public TMPro.TextMeshProUGUI cost;
    public TMPro.TextMeshProUGUI title;
    public TMPro.TextMeshProUGUI description;
    public Image picture;
    
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