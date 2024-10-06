using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Card;

public class CardsStack : MonoBehaviour
{
    public static List<Card> Cards = new List<Card>();
    private void Start()
    {
        DefineTrump();
    }
    private void DefineTrump()
    {
        for (int i = 1; i < 14; i++)
        {
            Card cardHeart = new Card(i, Suit.Hearts);
            Cards.Add(cardHeart);
            Card cardDiamond = new Card(i, Suit.Diamonds);
            Cards.Add(cardDiamond);
            Card cardClub = new Card(i, Suit.Clubs);
            Cards.Add(cardClub);
            Card cardSpead = new Card(i, Suit.Spades);
            Cards.Add(cardSpead);
        }
        //0‚Íjocker
        Card card = new Card(0, Suit.joker);
        Cards.Add(card);
    }
}