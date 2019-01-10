using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level5T : MonoBehaviour
{
    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    //for replayability, and to give player a goal by blocking off levels.

    public void Update()
    {
        if (PlayerPrefs.GetInt("Highscore") < 20000000)
        {
            text.text = "Unlock level 5 at 20mil highscore!";
        }
        else
        {
            text.text = "level 5";
        }
    }
}
