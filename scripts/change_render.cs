using System.Collections;
using System.Collections.Generic;
using SleekRender;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class change_render : MonoBehaviour
{
    public SleekRenderPostProcess fake;
    public PostProcessLayer real;
    public detectAttack alarm;
    public bool render;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        render = alarm.chren;
        if (render == true)
        {
            fake.enabled = false;
            real.enabled = true;
        }
    }
}
