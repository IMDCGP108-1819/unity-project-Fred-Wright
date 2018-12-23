using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Level") == 0)
        {
            text.text = "Please Select a Level";  // As playerpref for level is 0, level must be first picked
        }

        else
        {
            text.text = "";
        }

            
    }
}
