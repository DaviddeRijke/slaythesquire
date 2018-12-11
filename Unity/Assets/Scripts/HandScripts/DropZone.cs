using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;


public class DropZone : MonoBehaviour
{
    public CardEvent OnDrop = new CardEvent();
	public List<GameObject> playedCards = new List<GameObject>();

    /// <summary>
    /// This method is invoked by the (currently Temporary)Draggable script, whenever a draggable objects is dropped
    /// within the collider of a DropZone. The View3D is passed with the invoke. This way, this script has to know nothing,
    /// so the Stash and Playfield can have a DropZone to whose OnDrop they can listen.
    /// </summary>
    /// <param name="cardView"></param>
    public void DropCard(CardView3D cardView)
    {
		playedCards.Add(cardView.transform.parent.gameObject);
		OnDrop.Invoke(cardView.card);
    }
}
