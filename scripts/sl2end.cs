using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sl2end : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("savept") == 4)    PlayerPrefs.SetInt("savept", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
