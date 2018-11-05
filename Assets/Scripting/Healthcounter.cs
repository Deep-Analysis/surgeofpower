using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthcounter : MonoBehaviour
{
    public UnityEngine.UI.Text HealthDisplay;
    public UnityEngine.UI.Text HealthDisplay2;
    public UnityEngine.UI.Text HealthDisplay3;
    public UnityEngine.UI.Text HealthDisplay4;
    public int Health = 0;
    public int Healthperclick = 1;
    public int HealthperClick = -1;

    //player1
    public void clicked()
    {
        Health += Healthperclick;
        HealthDisplay.text = "Health:  " + Health;
    }

    public void Clicked()
    {
        Health += HealthperClick;
        HealthDisplay.text = "Health:  " + Health;
    }
    //player2
    public void clicked2()
    {
        Health += Healthperclick;
        HealthDisplay2.text = "Health:  " + Health;
    }

    public void Clicked2()
    {
        Health += HealthperClick;
        HealthDisplay2.text = "Health:  " + Health;
    }

    //player3
    public void clicked3()
    {
        Health += Healthperclick;
        HealthDisplay3.text = "Health:  " + Health;
    }

    public void Clicked3()
    {
        Health += HealthperClick;
        HealthDisplay3.text = "Health:  " + Health;
    }

        //player4
        public void clicked4()
        {
            Health += Healthperclick;
            HealthDisplay4.text = "Health:  " + Health;
        }

        public void Clicked4()
        {
            Health += HealthperClick;
            HealthDisplay4.text = "Health:  " + Health;
        }
    }