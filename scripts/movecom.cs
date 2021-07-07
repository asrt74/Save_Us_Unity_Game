using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecom : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 targetpos;
    public Vector2 targetpos2;
    public float shift = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            up();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            down();
        }
    }
    public void up()
    {
        targetpos = new Vector2(transform.position.x, transform.position.y + shift);
        transform.position = Vector2.MoveTowards(transform.position, targetpos, speed * Time.deltaTime);
    }

    public void down()
    {
        targetpos2 = new Vector2(transform.position.x, transform.position.y - shift);
        transform.position = Vector2.MoveTowards(transform.position, targetpos2, speed * Time.deltaTime);
    }
}
