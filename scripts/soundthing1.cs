using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundthing1 : MonoBehaviour
{
    public AudioSource asf1;
    public GameObject soundbase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (soundbase.activeSelf == true)
        {
           
            asf1.Pause();
           
        } 
       
    }
}
