using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level3T : MonoBehaviour
{
    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    //for replayability, and to give player a goal by blocking off levels.

    public void Update()
    {
        if (PlayerPrefs.GetInt("Highscore") < 100000)
        {
            text.text = "Unlock level 3 at 100k highscore!";
        }
        else
        {
            text.text = "level 3";
        }
    }

}
