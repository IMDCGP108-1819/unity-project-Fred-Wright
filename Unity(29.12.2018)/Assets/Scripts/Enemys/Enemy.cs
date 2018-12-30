using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public float t = 0;
    public int health;
    public GameObject end;
    public GameObject bullet;
    public int scoreValue; 

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
    void Update()
    {
        speed += Time.deltaTime / 5;
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void OnEnable()
    {
        health = health;
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