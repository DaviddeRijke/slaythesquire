using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;


public class DropZone : MonoBehaviour
{
    public CardEvent OnDrop = new CardEvent();
    
    public void DropCard(CardView3D cardView)
    {
        OnDrop.Invoke(cardView.card);
    }
}
