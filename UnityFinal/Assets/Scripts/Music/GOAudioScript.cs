using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOAudioScript : MonoBehaviour
{
    public AudioClip MMMusicClip;
    public AudioSource MMMusicSource;

    //when game is over, gameover music is played.


    private void Awake()
    {
        MMMusicSource = GetComponent<AudioSource>();
        Destroy(GameObject.FindWithTag("Music"));

    }
    void Start()
    {
        MMMusicSource.clip = MMMusicClip;
        if (PlayerPrefs.GetInt("Music") == 0)
        {
            MMMusicSource.Play();
        }

        else
        {
            MMMusicSource.GetComponent<AudioSource>().volume = 0f;
        }
    }

}
