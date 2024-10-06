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
}
