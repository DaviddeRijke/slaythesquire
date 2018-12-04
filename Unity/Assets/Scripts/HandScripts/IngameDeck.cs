using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityScript.Lang;
using Utils;

public class IngameDeck : MonoBehaviour
{
    //Deck is the data-object created by players outside of the game. IngameDeck are the instances + logic used ONLY ingame
    private Deck deck;
    private Queue<Card> cardsInDeck;
    public IntEvent OnRequestShuffle = new IntEvent();

    public void Init(Deck deck)
    {
        this.deck = deck;
        cardsInDeck = deck.Cards.Shuffle().ToQueue();
    }

    /// <summary>
    /// Shuffles all cards in the deck. The eventual shuffle is an extension method,
    /// declared in the 'Extensions' class. This is done for overview in code.
    ///
    /// The 'ToQueue' is not called here, because 'cardsInDeck' should not be overridden, but complemented.
    /// This way, the few cards remaining in the deck, will still be there in the same order.
    /// </summary>
    /// <param name="cards">Incoming cards from the Stash!</param>
    public void Shuffle(List<Card> cards)
    {
        var shuffled = cards.ToArray().Shuffle();
        foreach (var card in shuffled)
        {
            cardsInDeck.Enqueue(card);
        }
    }

    /// <summary>
    /// Draws cards from the deck. If there are not enough cards in the deck,
    /// request a shuffle at the Hand, which will pass cards from the Stash(discard pile),
    /// it will also do a new call on this method.
    /// </summary>
    /// <param name="amount">The amount of cards that should be drawn</param>
    /// <returns>Array of card objects that are drawn. The amount varies whether there were enough cards or not</returns>
    public Card[] DrawCards(int amount)
    {
        int actualAmount = Mathf.Min(amount, cardsInDeck.Count);
        if (actualAmount != amount)
        {
            OnRequestShuffle.Invoke(amount - actualAmount);
        }
        Card[] cardsDrawn = new Card[actualAmount];
        //Debug.Log(actualAmount);
        for (var i = 0; i < actualAmount; i++)
        {
            //Debug.Log(cardsInDeck.Count);
            cardsDrawn[i] = cardsInDeck.Dequeue();
        }
        return cardsDrawn;
    }   
}