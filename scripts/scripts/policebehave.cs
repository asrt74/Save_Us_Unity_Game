using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
using TMPro;

public class policebehave : MonoBehaviour
{


    //public TextMeshProUGUI scoretext;
    //public TextMeshProUGUI lives;

    public float armyspeed;
    public ParticleSystem effects;
    public int damage = 1;
    public Animator anim1;
    public Animator CAManim;
    //public static int savedPeople = 0;
    public Animator anim;
    public scoremanager sm;
    public AudioSource akk;


    // Start is called before the first frame update
    void Start()
    {

        akk = GameObject.FindGameObjectWithTag("spawnerthing").GetComponent<AudioSource>();
        buttonfn2.buttondonew += white;
        buttonfn2.buttondoner += red;
        buttonfn2.buttondoneo += orange;
        anim = GameObject.FindGameObjectWithTag("New tag").GetComponent<Animator>();
        CAManim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.left * armyspeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        {
            //GameObject army = null;
            white();
        }
        else
        if (Input.GetKeyDown(KeyCode.R))
        {
            red();
        }
        else
        
       
        if (Input.GetKeyDown(KeyCode.O))
        {
            orange();
        }
       
        
    }

    public void white()
    {
        if (this != null)
        {
            if (gameObject.tag == "wnp" || gameObject.tag == "wng")
            {
                after_death();
            }
        }
    }

    public void red()
    {
        if (this != null)
        {
            if (gameObject.tag == "rnb"|| gameObject.tag == "rnp")
            {
                after_death();
            }
        }
    }

    

    public void orange()
    {
        if (this != null)
        {
            if (gameObject.tag == "ong" || gameObject.tag == "onb")
            {
                after_death();
            }
        }
    }

    

    
    public void after_death()
    {

        if (anim1 != null)
        {
            akk.Play();//audio
            anim1.SetTrigger("vanish");
        }

        Destroy(gameObject, 0.1f);
        

        //army = GameObject.FindWithTag("white");
    }

   

    void OnTriggerEnter2D(Collider2D other)
    {

        /*  if (other.CompareTag("floor"))
          {

              //other.GetComponent<scoreboard>().score = savedPeople;

          }
*/
        if (other.CompareTag("Enemy"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            other.GetComponent<health>().life -= damage;

        }
        if (other.CompareTag("Enemy"))
        {
            anim.SetTrigger("damagetaken");

            int rand = Random.Range(1, 3);
            if (rand == 1)
            {
                CAManim.SetTrigger("s1");
            }
            else if (rand == 2)
            {
                CAManim.SetTrigger("s2");
            }
            else if (rand == 3)
            {
                CAManim.SetTrigger("s3");
            }

            Instantiate(effects, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
