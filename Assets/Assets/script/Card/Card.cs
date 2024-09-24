using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
   public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades,
        joker
    }
    public int Number { get; set; }
    public Suit suits { get; set; }
    public Card(int number, Suit suit)
    {
        Number = number;
        suits = suit;
    }
    public static List<Card> Cards = new List<Card>();
    private void Start()
    {
        DefineTrump();
    }
    private void DefineTrump()
    {
        for(int i = 1; i < 14; i++)
        {
            Card cardHeart = new Card(i, Suit.Hearts);
            Card.Cards.Add(cardHeart);
            Card cardDiamond = new Card(i, Suit.Diamonds);
            Card.Cards.Add(cardDiamond);
            Card cardClub=new Card(i, Suit.Clubs);
            Card.Cards.Add(cardClub);
            Card cardSpead=new Card(i, Suit.Spades);
            Card.Cards.Add(cardSpead);
        }
        //0‚Íjocker
        Card card =new Card(0, Suit.joker);
    }
}
