using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour{ 


    public float speed = 12f;

    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;
    }    

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Falling")
        {
           col.gameObject.SetActive(false);
    
        }
    }
}
