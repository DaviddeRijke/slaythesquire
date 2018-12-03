using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardView3D : MonoBehaviour {

    public Card card;
    
    public TMPro.TextMeshPro cost;
    public TMPro.TextMeshPro title;
    public TMPro.TextMeshPro description;
    public MeshRenderer picture;

    public UnityEvent OnSelect = new UnityEvent();
    public UnityEvent OnDeselect = new UnityEvent();
    public UnityEvent OnDrop = new UnityEvent();

	public void Start()
	{
		initCard(card);
	}

	public void initCard(Card c)
    {
        this.card = c;
        this.cost.SetText(card.cost.ToString());
        this.title.SetText(card.name);
        this.description.SetText(card.description);
    }
}