﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterexit : MonoBehaviour
{
    public Animator an;
    // Start is called before the first frame update
    void Start()
    {
        an.SetTrigger("enter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
