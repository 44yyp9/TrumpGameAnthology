using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dealing
{
    public List<List<Card>> dealCard(List<GameObject> charactor)
    {
        var cards = CardsStack.Cards;
        var chara_many=charactor.Count;
        int menber_cards = cards.Count / chara_many;
        int ovar_card = cards.Count % chara_many;
        List<List<Card>> hand_cards= new List<List<Card>>();
        for(int i = 0; i < chara_many; i++)
        {
            List<Card> hand_card = new List<Card>();
            for(int j = 0; j < menber_cards; j++)
            {
                var card = cards[0];
                hand_card.Add(card);
                cards.RemoveAt(0);
            }
            hand_cards.Add(hand_card);
        }
        if (cards.Count != 0)
        {
            for(int i = 0; i < ovar_card; i++)
            {
                var card = cards[0];
                hand_cards[i].Add(card);
                cards.RemoveAt(0);
            }
        }
        return hand_cards;
    }
}
