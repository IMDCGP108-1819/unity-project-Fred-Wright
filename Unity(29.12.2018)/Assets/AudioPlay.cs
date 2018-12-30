using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource Source;


    // Use this for initialization
    void OnEnable()
    {
        Source = GetComponent<AudioSource>();
        SetAudio();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            SetAudio();
        }
    }
    void SetAudio()
    {
        Source.Play();
    }
}