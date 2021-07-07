using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_scene : MonoBehaviour
{
    public void scene_change()
    {
        SceneManager.LoadScene("level");
    }
   
}
