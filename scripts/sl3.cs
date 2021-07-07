using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sl3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("savept") == 5)     PlayerPrefs.SetInt("savept", 6);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
