using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreyEnemy : MonoBehaviour
{
    public int health = 250;
    public GameObject end;
    public GameObject player;
    public GameObject bullet;
    public int scoreValue = 500;

    public GameObject deathEffect;
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

    void OnEnable()
    {
        health = 250;
    }

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
