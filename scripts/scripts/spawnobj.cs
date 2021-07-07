using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class spawnobj : MonoBehaviour
{
    public float startTimeBtwSpawn;

    private float timeBtwspawn;

    public GameObject[] army;

    public float decreasetime;
    public float mintime = 0.5f;
    public Animator an;

   
    // Update is called once per frame
    void Update()
    {
       
       
        
        if (timeBtwspawn <= 0)
        {
            int rand = Random.Range(0, army.Length);
            Instantiate(army[rand], transform.position, Quaternion.identity);
            timeBtwspawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > mintime)
            {
                startTimeBtwSpawn -= decreasetime;
            }
        }
        else
        {
            timeBtwspawn -= Time.deltaTime;
        }
    }

   

   
}
