using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;


public class health : MonoBehaviour
{
    public TextMeshProUGUI go;
    public TextMeshProUGUI go1;
    public GameObject obj1;
    public int life = 1; //3
    public GameObject ui;

    public static Action but;

    // Start is called before the first frame update
    void Start()
    {
         go = GameObject.Find("scoremind").GetComponent<TextMeshProUGUI>();
         go1 = GameObject.Find("no").GetComponent<TextMeshProUGUI>();
         obj1 = GameObject.Find("allbuttons");
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1f;
        if (life <= 0)
        {
            obj1.SetActive(false);
            go.fontSize = 0;
            go1.fontSize = 0;
            gotorestart();

           
        }
    }
    void gotorestart()
    {
     
            ui.SetActive(true);
            Time.timeScale = 0f;
        
    }
}
