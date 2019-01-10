using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartHelp : MonoBehaviour
{
    private Text text;
    private void Awake()
    {
        text = GetComponent<Text>();

    }
    //During the making of this gme, i origionally wnted an up

    //Starting help for idiots
    //When a level is played Starthelp is set 1 one, so this message only gets showed once


    private void Update()
    {
        if (PlayerPrefs.GetInt("StartHelp") == 0)
        {
            text.text = "The White Blocks are the easiest to destroy, only 2 hits!";
        }
        else
        {
            text.text = "";
        }
    }
}
