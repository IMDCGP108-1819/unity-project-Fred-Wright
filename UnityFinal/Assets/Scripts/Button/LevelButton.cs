using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour {

    public static int SceneLevel;

    //This is to set the global level, so if restart is pressed, it actually stays at that level.
    //This is seemingly complicated, but necessary

    public void SetLevel(int SceLevel)
    {
        SceneLevel = SceLevel;
        PlayerPrefs.SetInt("Level", SceneLevel);
    }
}
