using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerCost : MonoBehaviour
{
    public static int StartPowerCost;
    private Text text;

    private void Awake()
    {
        if (PlayerPrefs.GetInt("PowerCost") == 0)
        {
            PlayerPrefs.SetInt("PowerCost", 100);
        }

        text = GetComponent<Text>();

        if (StartPowerCost > PlayerPrefs.GetInt("PowerCost", 100))
        {
            PlayerPrefs.SetInt("PowerCost", StartPowerCost);
        }
    }
    private void Update()
    {
        text.text = "" + PlayerPrefs.GetInt("PowerCost");
    }

}
