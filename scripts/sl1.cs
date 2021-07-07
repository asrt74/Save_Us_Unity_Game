using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sl1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

        //if (PlayerPrefs.GetInt("savept") == 2)    
            PlayerPrefs.SetInt("savept", 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
