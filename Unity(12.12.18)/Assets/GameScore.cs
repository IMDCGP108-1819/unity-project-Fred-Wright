using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScore : MonoBehaviour
{

    public static int score;

    private TextMeshProUGUI text;

    void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        score = 0;
    }
    public void Update()
    {
        text.text = "" + score;
        PlayerPrefs.SetInt("RecentScore", score);

        if (score > PlayerPrefs.GetInt("RecentScore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }
}
