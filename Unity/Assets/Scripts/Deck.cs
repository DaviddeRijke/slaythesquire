using System.Collections.Generic;
    
//Deze class is het deck zoals die door de speler gemaakt wordt. Voor de class die de kaarten beheert INGAME, kijk naar IngameDeck!
public class Deck
{
    private List<Card> _cards;

    public List<Card> Cards
    {
        get { return _cards; }
        set { _cards = value; }
    }

}