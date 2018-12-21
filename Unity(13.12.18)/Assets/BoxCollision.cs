using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision: MonoBehaviour {

    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.velocity = new Vector3(0, -2f , 0 ); 
	}
}
