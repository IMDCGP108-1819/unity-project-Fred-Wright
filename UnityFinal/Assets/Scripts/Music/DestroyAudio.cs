using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAudio : MonoBehaviour
{
    //stops audio playing

    public void LoadScene(string level)
    {
        Destroy(GameObject.FindWithTag("Music"));
    }


}
