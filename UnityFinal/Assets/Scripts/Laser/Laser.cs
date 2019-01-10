using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public float speed = 20f;
    public int damage;
    public Rigidbody2D rb;

    //gets its power from the playerpref that is changed in upgrades

    private void Awake()
    {
        damage = PlayerPrefs.GetInt("Power");

    }

    //movement

    void OnEnable()
    {
        rb.velocity = transform.up * speed;
    }

    //upon collision, causes damage and resets the laser.

    void OnTriggerEnter2D(Collider2D col)
    {
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

        BlackEnemy benemy = col.gameObject.GetComponent<BlackEnemy>();
        if (benemy != null)
        {
            benemy.TakeDamage(damage);
            gameObject.SetActive(false);
        }
        BlueEnemy blenemy = col.gameObject.GetComponent<BlueEnemy>();
        if (blenemy != null)
        {
            blenemy.TakeDamage(damage);
            gameObject.SetActive(false);
        }
        GreenEnemy grenemy = col.gameObject.GetComponent<GreenEnemy>();
        if (grenemy != null)
        {
            grenemy.TakeDamage(damage);
            gameObject.SetActive(false);
        }
        RedEnemy renemy = col.gameObject.GetComponent<RedEnemy>();
        if (renemy != null)
        {
            renemy.TakeDamage(damage);
            gameObject.SetActive(false);
        }
        PinkEnemy penemy = col.gameObject.GetComponent<PinkEnemy>();
        if (penemy != null)
        {
            penemy.TakeDamage(damage);
            gameObject.SetActive(false);
        }

        //stops constant flight

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