using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GameStarting : MonoBehaviour,IShuffling,IDealing
{
    private int targetValue = 53;
    [SerializeField] List<GameObject> GameStartingObj= new List<GameObject>();
    [SerializeField] List<GameObject> Charactors= new List<GameObject>();
    void Start()
    {
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
        var my_charactor = Charactors[0].GetComponent<MyCharactor>();
        var enemy = Charactors[1].GetComponent<EnemyCharactor>();
        my_charactor.hand_card = dealing[0];
        enemy.hand_card= dealing[1];
    }
}
