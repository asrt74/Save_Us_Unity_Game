using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainmenu : MonoBehaviour
{
    private int pt;
   void Start()
    {
        if (PlayerPrefs.GetInt("savept") < 1) PlayerPrefs.SetInt("savept", 1);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.DeleteAll();

        }
    }
    public void playgame()
    {
        pt = PlayerPrefs.GetInt("savept", 1);
        if (pt == 1)     SceneManager.LoadScene("textstory");
        else if(pt != 1)    SceneManager.LoadScene("level");
    }

    public void quitgame()
    {
        Application.Quit();
    }

    public void helpmenu()
    {
        SceneManager.LoadScene("help");
    }
    
}
