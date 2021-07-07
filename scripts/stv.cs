using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stv : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("savept") == 1)          PlayerPrefs.SetInt("savept", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
