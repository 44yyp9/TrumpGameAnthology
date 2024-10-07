using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyCharactor :Player
{
    private void Update()
    {
        if (hand_card.Count != 0)
        {
            string stack = "";
            for(int i = 0; i < hand_card.Count; i++)
            {
                stack += hand_card[i].Number.ToString();
                stack += ",";
            }
            Debug.Log(stack);
        }
    }
}