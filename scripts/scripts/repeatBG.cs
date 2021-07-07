using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatBG : MonoBehaviour
{
    public float speed;
    public float endbg;
    public float starbg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= endbg)
        {
            Vector2 pos = new Vector2(starbg, transform.position.y);
            transform.position = pos;

        }
    }
}
