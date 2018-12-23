using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RecentScore : MonoBehaviour
{

    public static int score;
    public static int credits;

    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
        PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") + PlayerPrefs.GetInt("RecentScore") / 5);
    }
    public void Start()
    {
        text.text = "" + PlayerPrefs.GetInt("RecentScore") + "";

    }
}