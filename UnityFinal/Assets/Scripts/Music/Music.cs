using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Music : MonoBehaviour
{
    private Text text;


    //options for music.

    private void Awake()
    {
        text = GetComponent<Text>();

        //for some reason it was breaking, so this just reassigned music  so everything was working.

        if (PlayerPrefs.GetInt("Music") != 0 && PlayerPrefs.GetInt("Music") != 1)
        {
            PlayerPrefs.SetInt("Music", 0);
        }
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("Music") == 0)
        {
            text.text = "On";
        }
        if (PlayerPrefs.GetInt("Music") == 1)
        {
            text.text = "Off";
        }
    }
}
