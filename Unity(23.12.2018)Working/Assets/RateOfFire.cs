using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RateOfFire : MonoBehaviour
{
    public static int LaserSpawnRate;
    private Text text;


    private void Awake()
    {
        text = GetComponent<Text>();
      
    }
    void Start()
    {
        if (LaserSpawnRate > PlayerPrefs.GetInt("RateOfFire", 1))
        {
            PlayerPrefs.SetInt("RateOfFire", LaserSpawnRate);
        }
    }
    private void Update()
    {
        text.text = "" + PlayerPrefs.GetInt("RateOfFire").ToString();
    }
}
