using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class hit : MonoBehaviour
{
    public GameObject trails;
    public Rigidbody2D rb;
    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        //buttonfn3.buttonflaunch += ;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            launch();
        }
        
       
    }

    public void launch()
    {
       // Debug.Log(gameObject != null);

        if (gameObject != null)
        {
            rb.velocity = transform.right * speed * Time.deltaTime * -1f;
            trails.SetActive(true);
        }
        
    }
}
