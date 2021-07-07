using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class buttonfn2 : MonoBehaviour
{
    public static Action buttondonep;
    public static Action buttondoneo;
    public static Action buttondonew;
    public static Action buttondoner;
    public static Action buttondoneb;
    public static Action buttondoneg;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClickp()
    {
        buttondonep();
    }
    public void onClicko()
    {
        buttondoneo();
    }
    public void onClickw()
    {
        buttondonew();
    }
    public void onClickr()
    {
        buttondoner();
    }
    public void onClickb()
    {
        buttondoneb();
    }
    public void onClickg()
    {
        buttondoneg();
    }
}
