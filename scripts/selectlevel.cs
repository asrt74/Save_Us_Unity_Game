using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectlevel : MonoBehaviour
{
   
   
    public void introvid()
    {
        SceneManager.LoadScene("textstory");
    }

    public void one()
    {
        SceneManager.LoadScene("help1");//SampleScene
        
    }
    public void two()
    {
        SceneManager.LoadScene("help2");//2lev
    }
    public void three()
    {
        SceneManager.LoadScene("help3");//final
    }
    public void back()
    {
        SceneManager.LoadScene("mainmenu");
    }
    
}
