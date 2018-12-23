using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoFCost : MonoBehaviour
{
    public static int StartRoFCost;
    private Text text;


    private void Awake()
    {
        if (PlayerPrefs.GetInt("RoFCost") == 0)
        {
            PlayerPrefs.SetInt("RoFCost", 100);
        }
        text = GetComponent<Text>();
        if (StartRoFCost > PlayerPrefs.GetInt("RoFCost", 100))
        {
            PlayerPrefs.SetInt("RoFCost", StartRoFCost);
        }
    }
    private void Start()
    {
        if (StartRoFCost > PlayerPrefs.GetInt("RoFCost", 100))
        {
            PlayerPrefs.SetInt("RoFCost", StartRoFCost);
        }
    }
    void Update()
    {
        text.text = "" + PlayerPrefs.GetInt("RoFCost");
    }

}
