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
    //this is the only enemy script where velocity in not just gravity
    //it makes the game look clunky, however makes the first level be progressable.

    void Update()
    {
        speed += Time.deltaTime / 5;
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    //when spawned, health is:

    void OnEnable()
    {
        health = 100;
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