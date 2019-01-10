using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level4T : MonoBehaviour
{
    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    //for replayability, and to give player a goal by blocking off levels.

    public void Update()
    {
        if (PlayerPrefs.GetInt("Highscore") < 1000000)
        {
            text.text = "Unlock level 4 at 1mil highscore!";
        }
        else
        {
            text.text = "level 4";
        }
    }
}
