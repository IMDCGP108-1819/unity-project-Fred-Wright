﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSoundEffects : MonoBehaviour
{
    public void ChangeSoundEffect(string Level)
    {
        if (PlayerPrefs.GetInt("SoundEffects") == 0)
        {
            PlayerPrefs.SetInt("SoundEffects", 1);
        }
        else
        {
            PlayerPrefs.SetInt("SoundEffects", 0);
        }
    }
}
