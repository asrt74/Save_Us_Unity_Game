using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Playables;


public class armybehaviour : MonoBehaviour
{
    public AudioSource audioSource;
    //public AudioSource audioSource_end;
    public AudioSource audioSource_vanish;
    public GameObject spawner1;
    public GameObject times;
    public TextMeshProUGUI scoretext;
    //public TextMeshProUGUI lives;

    public float armyspeed;
    public ParticleSystem effects;
    public int damage = 1;
    public Animator anim1;
    public Animator CAManim;
    public Animator anim;
    //public static int savedPeople = 0;

    public scoremanager sm;

    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("robotool").GetComponent<AudioSource>();
        audioSource_vanish = GameObject.FindGameObjectWithTag("spawnerthing").GetComponent<AudioSource>();
        //audioSource_end = GameObject.FindGameObjectWithTag("bg_sound").GetComponent<AudioSource>();
        buttonfn.buttondonep += pink;
        buttonfn.buttondoney += yellow;
        buttonfn.buttondonew += white;
        buttonfn.buttondoner += red;
        buttonfn.buttondoneb += blue;
        buttonfn.buttondoneg += green;
        scoretext = GameObject.Find("scoremind").GetComponent<TextMeshProUGUI>();
        //lives = GameObject.Find("livesaved").GetComponent<TextMeshProUGUI>();
        CAManim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        anim = GameObject.FindGameObjectWithTag("New tag").GetComponent<Animator>();
        spawner1 = GameObject.FindGameObjectWithTag("spawnerthing");
        times = GameObject.FindGameObjectWithTag("timelines");
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector2.left * armyspeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        {
            //GameObject army = null;
            white();
        }else
        if (Input.GetKeyDown(KeyCode.R))
        {
            red();
        }
        else
        if (Input.GetKeyDown(KeyCode.G))
        {
           green();
        }
        else
        if (Input.GetKeyDown(KeyCode.Y))
        {
            yellow();
        }
        else
        if (Input.GetKeyDown(KeyCode.B))
        {

            blue();
        }
        else
        if (Input.GetKeyDown(KeyCode.P))
        {
            pink();
        }
    }

    public void white()
    {
        if (this != null)
        {
            if (gameObject.tag == "white")
            {
                after_death();
            }
        }
    }

    public void red()
    {
        if (this != null)
        {
            if (gameObject.tag == "red")
            {
                after_death();
            }
        }
    }

    public void green()
    {
        if (this != null)
        {
            if (gameObject.tag == "green")
            {
                after_death();
            }
        }
    }

    public void yellow()
    {
        if (this != null)
        {
            if (gameObject.tag == "yellow")
            {
                after_death();
            }
        }
    }

    public void blue()
    {
        if (this != null)
        {
            if (gameObject.tag == "blue")
            {
                after_death();
            }
        }
    }

    public void pink()
    {
        /*if (gameObject.tag == "pink")
        {
            
            
        }*/
        if (this != null) 
        {
            if (gameObject.tag == "pink")
            {
                after_death();
            }
        }
    }
    public void after_death()
    {
       
        if (anim1 != null)
        {           
            anim1.SetTrigger("code");
            audioSource_vanish.Play();//audio
        }

            Destroy(gameObject, 0.1f);
            scoreinc();
     
        //army = GameObject.FindWithTag("white");
    }

    public void scoreinc()
    {
        if (scoremanager.savedthings < 100-1)
        {
            //savedPeople += 1;
            scoremanager.savedthings += 1;
            //scoretext.text = savedPeople.ToString("0");
            scoretext.text = scoremanager.savedthings.ToString("0");
            //lives.text = savedPeople.ToString("0");
        }
        else if (scoremanager.savedthings >= 100-1)      //set level completation limit Default-70
        {
            spawner1.SetActive(false);
            gameObject.SetActive(false);
            times.GetComponent<PlayableDirector>().Play();
            times.GetComponent<AudioSource>().Play();//win
            
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
          /*  if (other.CompareTag("floor"))
            {
                
                //other.GetComponent<scoreboard>().score = savedPeople;

            }
*/            if (other.CompareTag("Enemy"))
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
            
            //audioSource_end.Stop();
            Destroy(gameObject);
            audioSource.Play();//audio
        }
       
    }
}
