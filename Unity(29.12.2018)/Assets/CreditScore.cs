using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreditScore : MonoBehaviour
{
    public static int credits;
    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        credits = 0;
    }
    public void Update()
    {
        text.text = "" + PlayerPrefs.GetInt("Credits") + " Credits!";
    }
}
