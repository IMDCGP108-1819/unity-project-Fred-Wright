using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    public static int LaserPower;
    private Text text;

    // Due to textmeshpro being wierd and just not working, i has to resort to using normal text, however i greatly prefer it
    // These functions get called alot of times over many scripts.

    private void Awake()
    {
        text = GetComponent<Text>();
    }

    // sets the int of laserpower in a playerpref, so this can get manipulated and used across scenes

    private void Start()
    {
        if (LaserPower > PlayerPrefs.GetInt("Power", 50))
        {
            PlayerPrefs.SetInt("Power", LaserPower);
        }
    }
    private void Update()
    {
        text.text = "" + PlayerPrefs.GetInt("Power").ToString();
    }
}
