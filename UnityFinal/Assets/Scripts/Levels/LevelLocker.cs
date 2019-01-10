using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLocker : MonoBehaviour
{
    public GameObject Level;
    public int highscore;

    //if highscore is not reached, the level is unreachable.

    private void Start()
    {
        if (PlayerPrefs.GetInt("Highscore") < highscore)
        {
            Level.SetActive(false);
        }
        else
        {
            Level.SetActive(true);
        }

    }
}
