using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaCount : MonoBehaviour
{
    public UnityEngine.UI.Text ManaDisplay;
    public UnityEngine.UI.Text ManaDisplay2;
    public UnityEngine.UI.Text ManaDisplay3;
    public UnityEngine.UI.Text ManaDisplay4;
    public int Mana = 0;
    public int Manaperclick = 1;
    public int ManaperClick = -1;

    //player1
    public void clicked()
    {
        Mana += Manaperclick;
        ManaDisplay.text = "Mana:  " + Mana;
    }

    public void Clicked()
    {
        Mana += ManaperClick;
        ManaDisplay.text = "Mana:  " + Mana;
    }
    //player2
    public void clicked2()
    {
        Mana += Manaperclick;
        ManaDisplay2.text = "Mana:  " + Mana;
    }

    public void Clicked2()
    {
        Mana += ManaperClick;
        ManaDisplay2.text = "Mana:  " + Mana;
    }
    //player3
    public void clicked3()
    {
        Mana += Manaperclick;
        ManaDisplay3.text = "Mana:  " + Mana;
    }

    public void Clicked3()
    {
        Mana += ManaperClick;
        ManaDisplay3.text = "Mana:  " + Mana;
    }
    //player4
    public void clicked4()
    {
        Mana += Manaperclick;
        ManaDisplay4.text = "Mana:  " + Mana;
    }

    public void Clicked4()
    {
        Mana += ManaperClick;
        ManaDisplay4.text = "Mana:  " + Mana;
    }
}
