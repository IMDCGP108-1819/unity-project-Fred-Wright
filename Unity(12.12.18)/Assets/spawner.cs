using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public int playerHealth = 1;

    public Transform Spawner;
    public float spawnRate = 10f;
    public GameObject fallingblock;

    public GameObject[] Blocks;

    public int MaxBlocks = 20;

    void Start()
    {
        InvokeRepeating("Spawn", spawnRate, spawnRate);
        Blocks = new GameObject[MaxBlocks];

        for (int i = 0; i < MaxBlocks; i++)
        {
            Vector3 position = new Vector3(Random.Range(-5.65f, 5.65f), 14, 0);
            Blocks[i] = Instantiate(fallingblock, position, Quaternion.identity);
            Blocks[i].SetActive(false);
        }

    }

    void Spawn ()
    {
        for (int i = 0; i < MaxBlocks; i++)
        {
            if ( !Blocks[i].activeSelf )
            {
                Blocks[i].transform.position = new Vector3(Random.Range(-5.65f, 5.65f), 14, 0);
                Blocks[i].SetActive(true);
                return;
            }
        }
    }


    // Update is called once per frame





    //    void Update () {
		// if (Time.time >= nextTimeToSpawn)
        
           // Instantiate(fallingblock, new Vector3(0, 5, -1), Quaternion.identity);
           // nextTimeToSpawn = 5f;
        
	
}
