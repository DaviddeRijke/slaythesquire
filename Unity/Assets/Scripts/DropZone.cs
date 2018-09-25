using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ZoneType
{
    DISCARD_PILE,
    EQUIPMENT_SLOT,
    FIELD,
}


public class DropZone : MonoBehaviour {

    public ZoneType type;

    public void DropCard(Card card)
    {
        // TODO: Check if Card can be activated
        // TODO: Return Card to hand if cannot be activated
        switch (type)
        {
            case ZoneType.DISCARD_PILE:
                // Discard Card
                break;
            case ZoneType.EQUIPMENT_SLOT:
                // Equip Card
                // This can change to Field where Equip Cards will be played to equip an item
                break;
            case ZoneType.FIELD:
                PlayCard(card);
                break;
            default:
                break;
        }
    }

    void PlayCard(Card card)
    {
        card.Activate();
        // TODO: Add to a list where later effects can be activated from
        Destroy(card.gameObject);
    }
}
