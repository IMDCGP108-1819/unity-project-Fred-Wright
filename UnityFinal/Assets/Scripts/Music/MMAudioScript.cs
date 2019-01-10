using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMAudioScript : MonoBehaviour
{
    public AudioClip MMMusicClip;
    public AudioSource MMMusicSource;


    //audio scripts to be assigned within unity for a song and gameobject.

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        MMMusicSource = GetComponent<AudioSource>();
        
    }
    void Start()
    {

        //if sound is off, it does not play.
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
