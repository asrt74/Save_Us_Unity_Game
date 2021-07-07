using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileslaunch : MonoBehaviour
{
    public GameObject[] miss;
    public GameObject b, w, p;
    public GameObject wh, bl, pi;
    // Start is called before the first frame update
    void OnEnable()
    {
        buttonfn3.buttonfblue += missblue;
        buttonfn3.buttonfwhite += misswhite;
        buttonfn3.buttonfpink += misspink;
    }
    void OnDisable()
    {
        buttonfn3.buttonfblue -= missblue;
        buttonfn3.buttonfwhite -= misswhite;
        buttonfn3.buttonfpink -= misspink;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        b = GameObject.FindGameObjectWithTag("bluemiss");
        w = GameObject.FindGameObjectWithTag("whitemiss");
        p = GameObject.FindGameObjectWithTag("pinkmiss");

        if (Input.GetKeyDown(KeyCode.J))
        {
            missblue();
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            misspink();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            misswhite();
        }
    }
    public void missblue()
    {
        if (miss[0] != null)
        {
            bl = Instantiate(miss[0], transform.position, Quaternion.identity);
            bl.transform.parent = gameObject.transform.parent;
            Destroy(w);
            Destroy(p);

        }

    }
    public void misspink()
    {
        if (miss[1] != null)
        {
            pi = Instantiate(miss[1], transform.position, Quaternion.identity);
            pi.transform.parent = gameObject.transform.parent;
            Destroy(w);
            Destroy(b);
        }
       
    }
    public void misswhite()
    {
        if (miss[2] != null)
        {
            wh = Instantiate(miss[2], transform.position, Quaternion.identity);
            wh.transform.parent = gameObject.transform.parent;
            Destroy(b);
            Destroy(p);
        }
       
    }
    
}
