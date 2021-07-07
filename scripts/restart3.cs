using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class restart3 : MonoBehaviour
{
    void Update()
    {
       
    }
    public void restartgame()
    {

        SceneManager.LoadScene("final");

    }
    public void mainmenuback()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
