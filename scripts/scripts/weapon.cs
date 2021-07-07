using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class weapon : MonoBehaviour
{
    public Transform firept;
    public GameObject impacteffect;
    public LineRenderer line;
    public int damage = 1;

    public TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    void Start()
    {
        buttonfn2.buttondoneg += green;
        buttonfn2.buttondonep += purple;
        buttonfn2.buttondoneb += blue;

        scoretext = GameObject.Find("scoremind").GetComponent<TextMeshProUGUI>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            green();
        }
        else
        if (Input.GetKeyDown(KeyCode.P))
        {
            purple();
        }
        
        else
        if (Input.GetKeyDown(KeyCode.B))
        {
            blue();
        }

    }

    public void blue()
    {
        if (this != null)
        {
            if (gameObject.tag == "rnb" || gameObject.tag == "onb")
            {
                action();
            }
        }
    }

    public void purple()
    {
        if (this != null)
        {
            if (gameObject.tag == "wnp" || gameObject.tag == "rnp")
            {
                action();
            }
        }
    }

    public void green()
    {
        if (this != null)
        {
            if (gameObject.tag == "ong" || gameObject.tag == "wng")
            {
                action();
            }
        }
    }

    public void action()
    {
        StartCoroutine(shoot());
    }
    public IEnumerator shoot()
    {
        RaycastHit2D hitobj = Physics2D.Raycast(firept.position, firept.right);

        if (hitobj)
        {
            enemyshield enemy = hitobj.transform.GetComponent<enemyshield>();
            if (enemy != null)
            {
                enemy.takedamage(damage);
                scoremanager.savedthings += 1;
                //scoretext.text = savedPeople.ToString("0");
                scoretext.text = scoremanager.savedthings.ToString("0");
            }

            Instantiate(impacteffect, hitobj.point, Quaternion.identity);

            line.SetPosition(0, firept.position);
            line.SetPosition(1, hitobj.point);
        }
        else
        {
           line.SetPosition(0, firept.position);
           line.SetPosition(1, firept.position + firept.right * 100) ;
        }
        line.enabled = true;

        yield return 0;

        line.enabled = false;
    }
}
