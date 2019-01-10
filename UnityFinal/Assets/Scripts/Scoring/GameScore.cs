using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{

    public static int score;

    private Text text;

    //prints score

    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }
    public void Update()
    {
        text.text = "" + score;
    }
}
