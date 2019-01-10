using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoFCost : MonoBehaviour
{
    public static int StartRoFCost;
    private Text text;


    // Due to textmeshpro being wierd and just not working, i has to resort to using normal text, however i greatly prefer it
    // These functions get called alot of times over many scripts.

    private void Awake()
    {

        // at the start of the game all prefs are 0, this sets the base powercost

        if (PlayerPrefs.GetInt("RoFCost") == 0)
        {
            PlayerPrefs.SetInt("RoFCost", 100);
        }
        text = GetComponent<Text>();
       
    }
    void Update()
    {
        text.text = "" + PlayerPrefs.GetInt("RoFCost");
    }

}
