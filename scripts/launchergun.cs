using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class launchergun : MonoBehaviour
{
    
    public Transform fp; 
    public GameObject[] rocketprefab;
   
    public float speed;
    //0=pink,1=blue,2=white

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            shootactivep();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            shootactiveb();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            shootactivew();
        }

    }
    
    public void shootactivep()
    {
        rocketprefab[0].SetActive(true);
        rocketprefab[1].SetActive(false);
        rocketprefab[2].SetActive(false);
       
    }

    public void shootactiveb()
    {
        rocketprefab[0].SetActive(false);
        rocketprefab[1].SetActive(true);
        rocketprefab[2].SetActive(false);
       
    }

    public void shootactivew()
    {
        rocketprefab[0].SetActive(false);
        rocketprefab[1].SetActive(false);
        rocketprefab[2].SetActive(true);
        
    }

   
}
