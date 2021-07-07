using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<heroxmove>().health -= 1;
            if (gameObject.name != "maze")      Destroy(gameObject);

        }
    }
}
