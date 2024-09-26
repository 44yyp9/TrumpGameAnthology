using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GameStarting : MonoBehaviour,IShuffling
{
    private int targetValue = 53;
    [SerializeField] List<GameObject> GameStartingObj= new List<GameObject>();
    void Start()
    {
        SetActiveObj(false);
        StartCoroutine(CheckValueCoroutine());
    }
    public IEnumerator CheckValueCoroutine()
    {
        while (true)
        {
            if (Card.Cards.Count== targetValue)
            {
                Shuffle();
                StartGame();
                yield break;
            }
            yield return null;
        }
    }
    public void Shuffle()
    {
        Card.Cards = Card.Cards.OrderBy(a => Guid.NewGuid()).ToList();
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
}
