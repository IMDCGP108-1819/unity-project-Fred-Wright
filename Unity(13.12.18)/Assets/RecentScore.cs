using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RecentScore : MonoBehaviour
{

    public TextMeshProUGUI Recentscore;
    private TextMeshProUGUI text;

    public void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        Recentscore.text = PlayerPrefs.GetInt("RecentScore").ToString();
    }
}