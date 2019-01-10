using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    // Exactly what you think, its the reset button.

    public void ResetPrefs(string level)
    {
        PlayerPrefs.DeleteAll();
    }
}