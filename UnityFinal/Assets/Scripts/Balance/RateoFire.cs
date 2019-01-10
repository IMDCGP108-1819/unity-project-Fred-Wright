using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateoFire : MonoBehaviour
{

    ////math when the button is pressed, changes multiple ints to scale the game, and its replayabililty over time 

    public void RateOfFire(string level)
    {

        if (PlayerPrefs.GetInt("Credits") >= PlayerPrefs.GetInt("RoFCost"))
        {
            PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - PlayerPrefs.GetInt("RoFCost")); //the form of currency
            PlayerPrefs.SetInt("RoFCost", PlayerPrefs.GetInt("RoFCost") + (PlayerPrefs.GetInt("RoFCost")));  //Timesing didnt work...
            PlayerPrefs.SetInt("RateOfFire", PlayerPrefs.GetInt("RateOfFire") + 1);  // the actual bit the player cares about.
            //makes it also that the start is easier, and feels more rewarding, so players stay.
        }

    }

}
