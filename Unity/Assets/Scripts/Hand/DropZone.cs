using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DropZone : MonoBehaviour {

	public Knight self;
	public Knight opponent;

    public void DropCard(CardView3D cardView)
    {
        PlayCard(cardView);
    }

    void PlayCard(CardView3D cardView)
    {
        Card card = cardView.card;
        if (card != null)
        {
            card.Activate(self, opponent);
            // TODO: Add to a list where later effects can be activated from
            cardView.gameObject.SetActive(false);
            Debug.Log("Card is played!");
        }
        else
        {
            Debug.Log("No card attached!");
        }
        
    }
}
