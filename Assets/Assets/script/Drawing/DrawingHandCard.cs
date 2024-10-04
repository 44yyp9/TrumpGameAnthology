using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DrawingHandCard : MonoBehaviour,IDrawingHandCard
{
    [SerializeField] GameObject enemy;
    private HandCard EnemyCard;
    private HandCard PlayerCard;
    private List<Card> Cards;

    void Start()
    {
        DrawHandCard();
    }
    public void DrawHandCard()
    {
        EnemyCard = enemy.GetComponent<HandCard>();
        PlayerCard = GetComponent<HandCard>();
        Cards = EnemyCard.HandCards;
        WaitEnter();
    }
    public void WaitEnter()
    {
        int _card_position = 0;
        StartCoroutine(StealCard());
        IEnumerator StealCard()
        {
            while (true)
            {
                SelectCard(_card_position);
                Debug.Log(_card_position);
                if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    EnemyCard.HandCards.RemoveAt(_card_position);
                    PlayerCard.HandCards.Add(Cards[_card_position]);
                    yield break;
                }
                yield return null;
            }
        }
    }
    private void SelectCard(int CardPosition)
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CardPosition -= 1;
        }else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CardPosition += 1;
        }
        if(CardPosition<0) CardPosition=Cards.Count;
        if (Cards.Count < CardPosition) CardPosition = 0;
    }
}
