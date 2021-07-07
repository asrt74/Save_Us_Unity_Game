using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class readynxt : MonoBehaviour
{
    public void ready()
    {
        SceneManager.LoadScene("level");
    }
}
