﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMAudioScript : MonoBehaviour
{
    public AudioClip MMMusicClip;
    public AudioSource MMMusicSource;


    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        MMMusicSource = GetComponent<AudioSource>();
        
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
