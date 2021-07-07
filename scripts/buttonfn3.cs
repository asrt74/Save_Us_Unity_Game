using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class buttonfn3 : MonoBehaviour
{
    static GameObject instance;

    public static Action buttonfup;
    public static Action buttonfdown;
    public static Action buttonfblue;
    public static Action buttonfpink;
    public static Action buttonfwhite;
    public static Action buttonflaunch;
    // Start is called before the first frame update
    void Start()
    {
       
              
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click_up()
    {
        buttonfup();
    }
    public void click_down()
    {
        buttonfdown();
    }
    public void click_pink()
    {
        buttonfpink();
    }
    public void click_white()
    {
        buttonfwhite();
    }
    public void click_blue()
    {
        buttonfblue();
    }
    public void click_launch()
    {
        //buttonflaunch();
        
        var missile = GameObject.FindGameObjectWithTag("pinkmiss");
        var missile1 = GameObject.FindGameObjectWithTag("whitemiss");
        var missile2 = GameObject.FindGameObjectWithTag("bluemiss");

        if (missile != null)
        {
            hit attackscript = missile.GetComponent<hit>();
            attackscript.launch();
        }
        else if (missile1 != null)
        {
            hit attackscript = missile1.GetComponent<hit>();
            attackscript.launch();
        }
        else if (missile2 != null)
        {
            hit attackscript = missile2.GetComponent<hit>();
            attackscript.launch();
        }
    }

     
}
