using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    public static int LaserPower;
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
    }
    private void Start()
    {
        if (LaserPower > PlayerPrefs.GetInt("Power", 50))
        {
            PlayerPrefs.SetInt("Pover", LaserPower);
        }
    }
    private void Update()
    {
        text.text = "" + PlayerPrefs.GetInt("Power").ToString();
    }
}
