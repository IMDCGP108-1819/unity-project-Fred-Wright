using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laser_Mechanic : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float laserSpawnRate;
    public int MaxLasers = 1000;
    public GameObject[] Lasers;
    public GameObject player;

    //allows for progression of increasing rateoffire

    private void Awake()
    {
        laserSpawnRate = 1f / (PlayerPrefs.GetInt("RateOfFire"));
    }

    // Instantiates a certain amount of lasers in a constant interval determined by rateoffire

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

    //upon collision, makes the score increase

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Falling")
        {
            player = col.gameObject;
            var score = GameScore.score;

            //sets the highscore if its larger than itself

            if (score > PlayerPrefs.GetInt("Highscore", 0))
            {
                PlayerPrefs.SetInt("Highscore", score);
            }

            //recentscore determines credits earned

            PlayerPrefs.SetInt("RecentScore", score);
            SceneManager.LoadScene("GameOverScene");
            PlayerPrefs.SetInt("StartHelp", 1);

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

