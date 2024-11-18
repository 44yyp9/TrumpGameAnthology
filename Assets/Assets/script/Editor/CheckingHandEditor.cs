using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CheckingHandEditor : EditorWindow
{
    private string enemy = "enemy";
    private string me = "me";
    [MenuItem("tools/Handwindow")]
    public static void create_window()
    {
        EditorWindow.GetWindow<CheckingHandEditor>(title: "HandWindow");
    }
    private void OnGUI()
    {
        var my_charactor=GameObject.Find("mychara");
        var enemy = GameObject.Find("enemy");
        var my_script = my_charactor.GetComponent<MyCharactor>();
        var enemy_script=enemy.GetComponent<EnemyCharactor>();
        var my_hand = my_script.hand_card;
        var enemy_hand=enemy_script.hand_card;
        string enemy_card_numbers = "";
        string enemy_card_suits = "";
        string my_card_numbers = "";
        string my_card_suits = "";
        for(int i = 0; i < my_hand.Count; i++)
        {
            if (i == 0)
            {
                my_card_numbers += "{";
                my_card_suits+="{";
            }else if (i == my_hand.Count-1)
            {
                my_card_numbers+= "}";
                my_card_suits += "}";
            }
            var suit_symbol = "";
        }
    }
}
