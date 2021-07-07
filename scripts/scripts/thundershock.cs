using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thundershock : MonoBehaviour
{
    public Animator CAManim;
    public Animator ts;
    // Start is called before the first frame update
    void Start()
    {
        CAManim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        int rand = Random.Range(1, 10000);
        if (rand == 27 && gameObject.tag != "thud")
        {
            camshake();
            ts.SetTrigger("t1");
        }
        if (rand == 14)
        {
            camshake();
            ts.SetTrigger("t2");
        }
        if (rand == 7)
        {
            camshake();
            ts.SetTrigger("t3");
        }
    }
    void camshake()
    {
        int rand = Random.Range(1, 3);
        if (rand == 1)
        {
            CAManim.SetTrigger("t1");
        }
        else if (rand == 2)
        {
            CAManim.SetTrigger("t2");
        }
       
    }
}
