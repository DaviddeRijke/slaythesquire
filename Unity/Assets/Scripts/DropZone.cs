using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DropZone : MonoBehaviour {

    public void DropCard(Card card)
    {
        PlayCard(card);
    }

    void PlayCard(Card card)
    {
        card.Activate();
        // TODO: Add to a list where later effects can be activated from
        Destroy(card.gameObject);
    }
}
