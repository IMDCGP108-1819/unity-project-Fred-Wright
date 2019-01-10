using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RateOfFire : MonoBehaviour
{
    public static int LaserSpawnRate;
    private Text text;

    // Due to textmeshpro being wierd and just not working, i has to resort to using normal text, however i greatly prefer it
    // These functions get called alot of times over many scripts.

    private void Awake()
    {
        text = GetComponent<Text>();     
    }

    private void Update()
    {
        text.text = "" + PlayerPrefs.GetInt("RateOfFire").ToString();
    }
}
