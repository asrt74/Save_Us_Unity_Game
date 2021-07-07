using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firesplash : MonoBehaviour
{
    public ParticleSystem effect;

    // Start is called before the first frame update
    
    void OnEnable()
    {
        buttonfn3.buttonfdown += burstpropeller;
        buttonfn3.buttonfup += burstpropeller;
    }
    void OnDisable()
    {
        buttonfn3.buttonfdown -= burstpropeller;
        buttonfn3.buttonfup -= burstpropeller;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            burstpropeller();
        }
            
    }
    public void burstpropeller()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
    }
}
