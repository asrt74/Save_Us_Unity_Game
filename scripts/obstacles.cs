using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public float speed;

    public int damage;

    void Update() 
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    
    }
        
    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<heroxmove>().health -= damage;
            Destroy(gameObject);
        }
    }*/
}
