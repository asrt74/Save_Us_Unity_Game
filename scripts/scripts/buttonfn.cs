using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class buttonfn : MonoBehaviour
{
    public static Action buttondonep;
    public static Action buttondoney;
    public static Action buttondonew;
    public static Action buttondoner;
    public static Action buttondoneb;
    public static Action buttondoneg;
    // Start is called before the first frame update
   

    public void onClickp()
    {
        buttondonep();
    }
    public void onClicky()
    {
        buttondoney();
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
