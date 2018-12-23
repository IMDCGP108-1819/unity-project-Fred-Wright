using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour {

    public static int SceneLevel;

    public void SetLevel(int SceLevel)
    {
        SceneLevel = SceLevel;
        PlayerPrefs.SetInt("Level", SceneLevel);
    }
}
