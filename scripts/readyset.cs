using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readyset : MonoBehaviour
{
    public Animator animt;
    // Start is called before the first frame update
    void Start()
    {
        animt.SetTrigger("ready");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
