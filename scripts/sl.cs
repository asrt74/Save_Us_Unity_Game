using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sl : MonoBehaviour
{
    private int pts;
    public Animator animobj;
    public Animator animlock;
    public Animator animobj2;
    public Animator animlock2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("savept"));
        pts = PlayerPrefs.GetInt("savept");
        if (pts == 3)
        {
            animlock.SetTrigger("break");
            animobj.SetTrigger("breakobj");
        }
         if (pts >= 4)
        {
            animlock.SetTrigger("ld");
            animobj.SetTrigger("td");
        }
         if (pts == 5)
        {
            animlock2.SetTrigger("fod");
            animobj2.SetTrigger("fodobj");
        }
        
         if (pts >= 6)
        {
            animlock2.SetTrigger("l1d");
            animobj2.SetTrigger("t1d");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
