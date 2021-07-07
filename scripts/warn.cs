using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warn : MonoBehaviour
{
    public Animator an;
    // Start is called before the first frame update
    void Start()
    {
        an.SetTrigger("ready");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
