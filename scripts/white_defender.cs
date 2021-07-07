using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class white_defender : MonoBehaviour
{
    public ParticleSystem misseffects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "pinkmiss" || other.gameObject.tag == "bluemiss")
        {
            Destroy(other.gameObject);
            Instantiate(misseffects, new Vector2(other.transform.position.x - 4.5f, other.transform.position.y), Quaternion.identity);

        }
    }

}
