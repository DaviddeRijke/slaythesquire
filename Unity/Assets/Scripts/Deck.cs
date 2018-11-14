using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Deze class is het deck zoals die door de speler gemaakt wordt. Voor de class die de kaarten beheert INGAME, kijk naar IngameDeck!
[Serializable]
public class Deck : MonoBehaviour
{
    public Card[] Cards;
}