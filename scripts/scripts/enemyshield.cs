using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class enemyshield : MonoBehaviour
{
    public int shieldhealth = 60;
    public AudioSource aff;
    public Animator shieldanim;
    public Animator powersource;
    public Animator camanim;
    public GameObject tl;
    public GameObject spawnerthing2;

    public GameObject wng, rnp, ong, onb, rnb, wnp;
   

    void Start()
    {
        camanim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        tl = GameObject.FindGameObjectWithTag("timelines");
        spawnerthing2 = GameObject.FindGameObjectWithTag("spawnerthing");

    }
    public void takedamage(int damage)
    {
        shieldhealth -= damage;

        var rand = Random.Range(1, 3);
        if (rand == 1)    camanim.SetTrigger("s3");
        else if (rand == 2)    camanim.SetTrigger("s2");
        else if (rand == 3)     camanim.SetTrigger("s1");

        if (shieldhealth == 50)
        {
           // camanim.SetTrigger("s3");
            shieldanim.SetTrigger("b");
        }
        else if (shieldhealth == 40)
        {
           // camanim.SetTrigger("s2");
            shieldanim.SetTrigger("b1");
        }
        else if (shieldhealth == 30)
        {
           // camanim.SetTrigger("s1");
            shieldanim.SetTrigger("b2");
        }
        else if (shieldhealth == 22)
        {
           // camanim.SetTrigger("s3");
            shieldanim.SetTrigger("b3");
        }
        else if (shieldhealth == 15)
        {
           // camanim.SetTrigger("s2");
            shieldanim.SetTrigger("b4");
        }
        else if (shieldhealth == 8)
        {
           // camanim.SetTrigger("s1");
            shieldanim.SetTrigger("b5");
        }
        else if (shieldhealth == 5)
        {
           // camanim.SetTrigger("s3");
            shieldanim.SetTrigger("bf");
        }
        

 if (shieldhealth <= 0)
        {
            camanim.SetTrigger("s2");
            spawnerthing2.SetActive(false);
            aff.Play();//win

            die();

            wng = GameObject.FindGameObjectWithTag("wng");
            if(wng != null)  wng.SetActive(false);

            rnp = GameObject.FindGameObjectWithTag("rnp");
            if (rnp != null)  rnp.SetActive(false);

            ong = GameObject.FindGameObjectWithTag("ong");
            if (ong != null)  ong.SetActive(false);

            onb = GameObject.FindGameObjectWithTag("onb");
            if (onb != null)  onb.SetActive(false);

            rnb = GameObject.FindGameObjectWithTag("rnb");
            if (rnb != null)  rnb.SetActive(false);

            wnp = GameObject.FindGameObjectWithTag("wnp");
            if (wnp != null)  wnp.SetActive(false);

        }
    }

    void die()
    {
        tl.GetComponent<PlayableDirector>().Play();
        powersource.SetTrigger("fail");
        Destroy(gameObject);
        
    }
}
