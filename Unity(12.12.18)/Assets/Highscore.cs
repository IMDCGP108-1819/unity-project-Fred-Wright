using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
   
    public TextMeshProUGUI HighScore;
    private TextMeshProUGUI text;

    public void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        HighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }


}
