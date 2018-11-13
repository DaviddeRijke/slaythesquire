using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;


public class DropZone : MonoBehaviour
{
    public CardEvent OnDrop = new CardEvent();

	public Knight self;
	public Knight opponent;

    public void DropCard(CardView3D cardView)
    {
        OnDrop.Invoke(cardView.card);
    }
}
