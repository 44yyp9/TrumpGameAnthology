using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Shuffling : MonoBehaviour
{
    [SerializeField] int targetValue = 53; // 発火する数値

    void Start()
    {
        StartCoroutine(CheckValueCoroutine());
    }

    IEnumerator CheckValueCoroutine()
    {
        while (true)
        {
            if (Card.Cards.Count == targetValue)
            {
                Shuffle();
                yield break; // コルーチンを終了して再度発火しないようにする
            }
            yield return null; // 次のフレームまで待機
        }
    }
    private void Shuffle()
    {
        Card.Cards=Card.Cards.OrderBy(a=>Guid.NewGuid()).ToList();
    }
}
