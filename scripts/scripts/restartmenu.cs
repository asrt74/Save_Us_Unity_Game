using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class restartmenu : MonoBehaviour
{
    
  
   
    void Update()
    {
        
    }
    public void restartgame()
    {
    
         SceneManager.LoadScene("lev1");
           
    }
    public void mainmenuback()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
