﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PinkEnemy : MonoBehaviour
{
    public int health = 20000;
    public GameObject end;
    public GameObject player;
    public GameObject bullet;
    public int scoreValue = 200000;

    //basic damage function, where damage is taken, and when health is 0, it dies and adds score.

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        gameObject.SetActive(false);
        GameScore.score += scoreValue;

    }

    //when spawned, health is:

    void OnEnable()
    {
        health = 7500;                         //Can't use same enemy script due to onenable being different int's
    }

    //to make it so blocks dont fall constantly
    //collision with bullets


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Floor")
        {
            gameObject.SetActive(false);
        }
        if (col.gameObject.tag == "Bullet")
        {
            bullet = col.gameObject;
            bullet.SetActive(false);
        }
    }

}