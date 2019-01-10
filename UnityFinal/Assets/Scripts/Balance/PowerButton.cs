using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButton : MonoBehaviour
{

    //math when the button is pressed, changes multiple ints to scale the game, and its replayabililty over time 

    public void BoostPower(string level)
    {

        if (PlayerPrefs.GetInt("Credits") >= PlayerPrefs.GetInt("PowerCost"))
        {
            PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - PlayerPrefs.GetInt("PowerCost")); //the form of currency
            PlayerPrefs.SetInt("PowerCost", PlayerPrefs.GetInt("PowerCost") + (PlayerPrefs.GetInt("PowerCost")));  //Timesing didnt work...
            PlayerPrefs.SetInt("Power", PlayerPrefs.GetInt("Power") + 50);  // the actual bit the player cares about.
        }

    }

}
