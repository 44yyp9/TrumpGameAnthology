using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingCard
{
    public List<Card> thorw(List<Card> cards)
    {
        for(int i = 0; i < cards.Count; i++)
        {
            var taget_card = cards[i].Number;
            for (int j = i + 1; j < cards.Count; j++)
            {
                var tageted_card= cards[j].Number;
                if (taget_card == tageted_card)
                {
                    cards.RemoveAt(i);
                    cards.RemoveAt(j);
                    i -= 1;
                    break;
                }
            }
        }
        return cards;
    }
}
