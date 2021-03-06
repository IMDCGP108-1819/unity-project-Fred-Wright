﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner: MonoBehaviour {

    public int playerHealth = 1;

    public Transform spawner;
    public float spawnRate = 1f;
    public GameObject Block;

    public GameObject[] Blocks;

    public int MaxBlocks = 20;


    // Instantiates a certain amount of blocks in a constant interval


    void Start()
    {
        InvokeRepeating("Spawn", spawnRate, spawnRate);  //As i cannot change the repeat rate, i changed the movement of
        Blocks = new GameObject[MaxBlocks];              //the easiest block to increase over time so the game could not be endless

        for (int i = 0; i < MaxBlocks; i++)
        {
            Vector3 position = new Vector3(Random.Range(-5.65f, 5.65f), 7, 0);
            Blocks[i] = Instantiate(Block, position, Quaternion.identity);
            Blocks[i].SetActive(false);
        }

    }

    void Spawn ()
    {
        for (int i = 0; i < MaxBlocks; i++)
        {
            if ( !Blocks[i].activeSelf )
            {
                Blocks[i].transform.position = new Vector3(Random.Range(-5.65f, 5.65f), 7, 0);
                Blocks[i].SetActive(true);
                return;
            }
        }
    }
}
