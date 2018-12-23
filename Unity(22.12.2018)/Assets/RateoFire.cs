using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateoFire : MonoBehaviour
{

    public void RateOfFire(string level)
    {

        if (PlayerPrefs.GetInt("Credits") > PlayerPrefs.GetInt("RoFCost"))
        {
            PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - PlayerPrefs.GetInt("RoFCost"));
            PlayerPrefs.SetInt("RoFCost", PlayerPrefs.GetInt("RoFCost") + (PlayerPrefs.GetInt("RoFCost")));  //Timesing didnt work...
            PlayerPrefs.SetInt("RateOfFire", PlayerPrefs.GetInt("RateOfFire") + 1);
        }

    }

}
