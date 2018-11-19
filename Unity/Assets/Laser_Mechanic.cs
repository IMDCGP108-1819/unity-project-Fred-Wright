using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Mechanic : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float laserSpawnRate = 0.1f;
    public int MaxLasers = 100;
    public GameObject[] Lasers;



    void Start()
    {
        InvokeRepeating("Spawn", laserSpawnRate, laserSpawnRate);
        Lasers = new GameObject[MaxLasers];       
  
        for (int i = 0; i < MaxLasers; i++)
        {
            Lasers[i] = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Lasers[i].SetActive(false);
        }
    }

    void Spawn()
    {
        for (int i = 0; i < MaxLasers; i++)
        {
            if (!Lasers[i].activeSelf)
            {
                Lasers[i].transform.position = firePoint.position;
                Lasers[i].SetActive(true);
                return;
            }
        }
    }
}






    // Update is called once per frame
    /*   void Update () {
           if (Input.GetButtonDown("Fire1"))
           {
               Shoot();
           }
       }
       // this should be the shootey bit
       void Shoot ()
       {
           Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
       }
   */

