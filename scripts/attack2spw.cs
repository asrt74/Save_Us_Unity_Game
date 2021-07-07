using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack2spw : MonoBehaviour
{
    public GameObject[] rotbox;
    public float startspw;
    private float timespw;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timespw <= 0)
        {
            int rand = Random.Range(0, rotbox.Length);

            Instantiate(rotbox[rand], transform.position, Quaternion.identity);

            timespw = startspw;
        }
        else 
        {
            timespw -= 0.01f;
        }
        
    }
}
