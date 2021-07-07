using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class heroxmove : MonoBehaviour
{
    public TextMeshProUGUI go;
    public TextMeshProUGUI go1;
    public GameObject obj1;
    public GameObject ui;

    public Animator animdam;
    
    public Vector2 burstpos;
    public Vector2 targetpos;
    public float yinc;
    public float speed;

    public Animator anim;

    public int health = 3;

    public float maxheight = 24f;
    public float minheight = -6f;
    public Animator camanim;
    // Start is called before the first frame update
    void OnEnable()
    {
        buttonfn3.buttonfdown += moveDown;
        buttonfn3.buttonfup += moveUp;
    }
    void OnDisable()
    {
        buttonfn3.buttonfdown -= moveDown;
        buttonfn3.buttonfup -= moveUp;
    }



    void Start()
    {
        go = GameObject.Find("scoremind").GetComponent<TextMeshProUGUI>();
        go1 = GameObject.Find("no").GetComponent<TextMeshProUGUI>();
        obj1 = GameObject.Find("allbuttons");
        //fsp = GetComponent<firesplash>();
        //ui = GameObject.FindGameObjectWithTag("uimenu");
        camanim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (health <= 0)
        {
            Time.timeScale = 0f;

            obj1.SetActive(false);
            go.fontSize = 0;
            go1.fontSize = 0;
            gotorestart();
        }


        transform.position = Vector2.MoveTowards(transform.position, targetpos, speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.W) && (transform.position.y + yinc) <= maxheight)
        {
            codeforup();

        }
        else if (Input.GetKeyDown(KeyCode.S) && (transform.position.y - yinc) >= minheight)
        {
            codefordown();

        }
       
    }
    void gotorestart()
    {
       
        //DontDestroyOnLoad(this.gameObject);
        ui.SetActive(true);
        Time.timeScale = 0f;


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "danger" || other.gameObject.tag == "attack2blox")
        {
            animdam.SetTrigger("damagetaken");
            camanim.SetTrigger("s1");
            health -= 1;
        }
    }

    public void moveUp()
    {
        if ((transform.position.y + yinc) <= maxheight)
        {
            codeforup();
        }
    }

    public void moveDown()
    {
        if ((transform.position.y - yinc) >= minheight)
        {
            codefordown();
        }
    }

    public void codeforup()
    {
        targetpos = new Vector2(transform.position.x, transform.position.y + yinc);
        anim.SetTrigger("push");

      
    }
    public void codefordown()
    {
        targetpos = new Vector2(transform.position.x, transform.position.y - yinc);
        anim.SetTrigger("push");
    }
}
