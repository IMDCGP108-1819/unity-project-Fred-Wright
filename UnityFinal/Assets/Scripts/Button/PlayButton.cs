using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void LoadScene(string level)
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level").ToString());  //to actually do to previously played level
        PlayerPrefs.SetInt("StartHelp", 1); //So thats starthelp doesnt play all the time
    }

    // at the start of the game all prefs are 0, this sets the base power, rateoffire and level.
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


