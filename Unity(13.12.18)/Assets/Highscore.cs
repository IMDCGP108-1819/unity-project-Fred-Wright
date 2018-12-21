using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int score;

    public void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        score = PlayerPrefs.GetInt("Highscore");

        text.text = score.ToString();
    }


}
