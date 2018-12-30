using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffect : MonoBehaviour
{
    private Text text;

    private void Awake()
    {
        text = GetComponent<Text>();
        if (PlayerPrefs.GetInt("SoundEffects") != 0 && PlayerPrefs.GetInt("SoundEffects") != 1)
        {
            PlayerPrefs.SetInt("SoundEffects", 0);
        }
    }
    void Update()
    {
        if (PlayerPrefs.GetInt("SoundEffects") == 0)
        {
            text.text = "On";
        }
        if (PlayerPrefs.GetInt("SoundEffects") == 1)
        {
            text.text = "Off";
        }
    }

}
