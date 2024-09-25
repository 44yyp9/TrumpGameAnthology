using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Shuffling : MonoBehaviour
{
    [SerializeField] int targetValue = 53; // ���΂��鐔�l

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
                yield break; // �R���[�`�����I�����čēx���΂��Ȃ��悤�ɂ���
            }
            yield return null; // ���̃t���[���܂őҋ@
        }
    }
    private void Shuffle()
    {
        Card.Cards=Card.Cards.OrderBy(a=>Guid.NewGuid()).ToList();
    }
}
