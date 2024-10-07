using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GameStarting : MonoBehaviour,IShuffling,IDealing,IThrowingCard
{
    private int targetValue = 53;
    [SerializeField] List<GameObject> GameStartingObj= new List<GameObject>();
    [SerializeField] List<GameObject> Charactors= new List<GameObject>();
    MyCharactor my_charactor;
    EnemyCharactor enemy;
    void Start()
    {
        my_charactor = Charactors[0].GetComponent<MyCharactor>();
        enemy = Charactors[1].GetComponent<EnemyCharactor>();
        SetActiveObj(false);
        StartCoroutine(CheckValueCoroutine());
    }
    public IEnumerator CheckValueCoroutine()
    {
        while (true)
        {
            if (CardsStack.Cards.Count== targetValue)
            {
                Shuffle();
                deal();
                my_charactor.hand_card = throwCard(my_charactor.hand_card);
                enemy.hand_card = throwCard(enemy.hand_card);
                StartGame();
                yield break;
            }
            yield return null;
        }
    }
    public void Shuffle()
    {
        CardsStack.Cards = CardsStack.Cards.OrderBy(a => Guid.NewGuid()).ToList();
    }
    private void StartGame()
    {
        SetActiveObj(true);
    }
    private void SetActiveObj(bool Active)
    {
        for(int i = 0; i < GameStartingObj.Count; i++)
        {
            GameStartingObj[i].SetActive(Active);
        }
    }
    public void deal()
    {
        //‚±‚±‚ÌŽè‘±‚«•û•Ï‚¦‚½‚¢
        var dealingScript = new Dealing();
        var dealing = dealingScript.dealCard(Charactors);
        my_charactor.hand_card = dealing[0];
        enemy.hand_card= dealing[1];
    }
    public List<Card> throwCard(List<Card> cards)
    {
        var throwingScript = new ThrowingCard();
        var result_cards = throwingScript.thorw(cards);
        return result_cards;
    }
}
