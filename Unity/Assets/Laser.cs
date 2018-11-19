using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;

    // Use this for initialization
    void OnEnable()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Laser::OnTriggerEnter2D::" + col.gameObject.name);
        Enemy enemy = col.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            gameObject.SetActive(false);
        }
        GreyEnemy genemy = col.gameObject.GetComponent<GreyEnemy>();
        if (genemy != null)
        {
            genemy.TakeDamage(damage);
            gameObject.SetActive(false);
        }
        if (col.gameObject.tag == "Top")
        {
            gameObject.SetActive(false);
        }
        if (col.gameObject.tag == "Falling")
        {
            gameObject.SetActive(false);
        }
    }

}