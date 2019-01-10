using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour {


    // to transtition through scenes.


    public void LoadScene(string level)
    {
        Application.LoadLevel(level);
    }
}
