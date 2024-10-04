using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    public void DrawStack(List<Card> MyHandCards)
    {
        var TopCard = Card.Cards[0];
        Card.Cards.RemoveAt(0);
        MyHandCards.Add(TopCard);
    }
}