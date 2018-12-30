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
