﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sl2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("savept") == 3 )      PlayerPrefs.SetInt("savept", 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
