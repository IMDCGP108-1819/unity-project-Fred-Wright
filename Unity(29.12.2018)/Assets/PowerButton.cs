using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButton : MonoBehaviour
{
    public void BoostPower(string level)
    {

        if (PlayerPrefs.GetInt("Credits") > PlayerPrefs.GetInt("PowerCost"))
        {
            PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - PlayerPrefs.GetInt("PowerCost"));
            PlayerPrefs.SetInt("PowerCost", PlayerPrefs.GetInt("PowerCost") + (PlayerPrefs.GetInt("PowerCost")));  //Timesing didnt work...
            PlayerPrefs.SetInt("Power", PlayerPrefs.GetInt("Power") + 50);
        }

    }

}
