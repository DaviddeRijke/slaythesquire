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
	    card.OnEnable.AddListener(Enable);
	    card.OnDisable.AddListener(Disable);
        this.cost.SetText(card.cost.ToString());
        this.title.SetText(card.name);
        this.description.SetText(card.description);
    }

	public void Enable()
	{
		gameObject.SetActive(true);
	}

	public void Disable()
	{
		gameObject.SetActive(false);
	}
}