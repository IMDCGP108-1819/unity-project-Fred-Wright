using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void LoadScene(string level)
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level").ToString());
        PlayerPrefs.SetInt("StartHelp", 1);
    }
    private void Awake()
    {
        if (PlayerPrefs.GetInt("RateOfFire") == 0)
        {
            PlayerPrefs.SetInt("RateOfFire", 1);
        }

        if (PlayerPrefs.GetInt("Power") == 0)
        {
            PlayerPrefs.SetInt("Power", 50);
        }
    }
    public void Update()
    {
        if (PlayerPrefs.GetInt("Level") == 0)
        {
            PlayerPrefs.SetInt("Level", 1);
        }


        }
    }


