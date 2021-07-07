using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;

public class detectAttack : MonoBehaviour
{
    public AudioSource asp1;
    public AudioSource asp2;
    public AudioSource hurtaudio;
    public int roboHealth = 50;
    public TextMeshProUGUI scoretext;
    public scoremanager sm;
    public Animator cam;
    public ParticleSystem misseffects1;
    public Animator bowanim;
    public PlayableDirector gameend;
    public Animator thunder;
    public GameObject blackbg1;
    public GameObject blackbg2;
    public Animator buttonsgone;
    public GameObject whitebg;
    public GameObject arm1;
    public GameObject tail1;
    private bool bl = true;
    public GameObject blackbg;
    public GameObject bub;
    public GameObject lastscene;
    public bool chren = false;
    public Animator robohurt; //new1

    // Start is called before the first frame update
    void Start()
    {
        asp1 = GameObject.FindGameObjectWithTag("bg_soundlev3").GetComponent<AudioSource>();
        asp2 = GameObject.Find("background").GetComponent<AudioSource>();
        hurtaudio = GameObject.Find("robobody").GetComponent<AudioSource>();
        asp2.Play();
        scoretext = GameObject.Find("scoremind").GetComponent<TextMeshProUGUI>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(roboHealth < 1 && bl)
        {
            asp2.Stop();
            asp1.Play();//audio
            chren = true;
            buttonsgone.SetTrigger("remove");
            StartCoroutine(lastthing());
        }
    }

    public void scoreinc()
    {

        //savedPeople += 1;
        scoremanager.savedthings += 1;
        //scoretext.text = savedPeople.ToString("0");
        scoretext.text = scoremanager.savedthings.ToString("0");
        //lives.text = savedPeople.ToString("0");

    }
    IEnumerator l1()
    {
        
        yield return new WaitForSeconds(1f);
        thunder.SetTrigger("t1");
        whitebg.SetActive(true);
        arm1.SetActive(true);
        tail1.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        whitebg.SetActive(false);
        blackbg.SetActive(true);
        blackbg1.SetActive(true);
        blackbg2.SetActive(true);
        yield return new WaitForSeconds(5f);
        //gameend.Play();
        bub.SetActive(true);
        yield return new WaitForSeconds(6.5f);
        lastscene.SetActive(true);
    }
    IEnumerator lastthing()
    {
        bl = false;
        yield return new WaitForSeconds(0.30f);
        bowanim.SetTrigger("close");
        yield return new WaitForSeconds(5f);
        cam.SetTrigger("s3");
        
        StartCoroutine(l1());


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bluemiss" || other.gameObject.tag == "whitemiss" || other.gameObject.tag == "pinkmiss")
        {
            scoreinc();
            int rand = Random.Range(1, 2);
            if(rand == 1)    cam.SetTrigger("s2");
            else if (rand == 2)    cam.SetTrigger("s3");
            Instantiate(misseffects1, new Vector2(other.transform.position.x - 4.5f, other.transform.position.y), Quaternion.identity);
            Destroy(other.gameObject);
            hurtaudio.Play();//audio
            robohurt.SetTrigger("hurted");//new1
            roboHealth -= 1;
 
        }
    }
}
