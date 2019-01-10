using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text text;
    public int score;

    //prints highscore

    public void Start()
    {
        text = GetComponent<Text>();
        score = PlayerPrefs.GetInt("Highscore");

        text.text = score.ToString();
    }


}
