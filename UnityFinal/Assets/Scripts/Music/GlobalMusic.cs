using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlobalMusic : MonoBehaviour
{

    public void ChangeMusic(string Level)
    {

        // at start, all playerprefs are set to 0, this reassignes it so it can be changed in settings.

        if (PlayerPrefs.GetInt("Music") == 0)
        {
            PlayerPrefs.SetInt("Music", 1);
            Destroy(GameObject.FindWithTag("Music"));

        }
        else
        {
            PlayerPrefs.SetInt("Music", 0);
        }
    }
}
