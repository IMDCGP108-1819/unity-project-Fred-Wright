using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackblock : MonoBehaviour
{

    public int playerHealth = 1;

    public Transform BlackSpawner;
    public float spawnRate = 1f;
    public GameObject BlackBlock;

    public GameObject[] Blocks;

    public int MaxBlocks = 20;

    void Start()
    {
        InvokeRepeating("Spawn", spawnRate, spawnRate);
        Blocks = new GameObject[MaxBlocks];

        for (int i = 0; i < MaxBlocks; i++)
        {
            Vector3 position = new Vector3(Random.Range(-5.65f, 5.65f), 7, 0);
            Blocks[i] = Instantiate(BlackBlock, position, Quaternion.identity);
            Blocks[i].SetActive(false);
        }

    }

    void Spawn()
    {
        for (int i = 0; i < MaxBlocks; i++)
        {
            if (!Blocks[i].activeSelf)
            {
                Blocks[i].transform.position = new Vector3(Random.Range(-5.65f, 5.65f), 7, 0);
                Blocks[i].SetActive(true);
                return;
            }
        }
    }
    
}
