using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowattack : MonoBehaviour
{
    public Animator bowanim;
    private bool update_attack = false;
    private bool start_new_attack = true;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        bowanim = GetComponent<Animator>();
        StartCoroutine(attacktime());
    }

    // Update is called once per frame
    void Update()
    {
        if (update_attack && start_new_attack )
        {
            start_new_attack = false;
            StartCoroutine(update_attacks());
        }
    }

    IEnumerator attacktime()
    {
        yield return new WaitForSeconds(10f);
        bowanim.SetTrigger("a1");

        yield return new WaitForSeconds(20f);
        bowanim.SetTrigger("a2");

        yield return new WaitForSeconds(20f);
        bowanim.SetTrigger("a3");
        

        update_attack = true;
    }

    IEnumerator update_attacks()
    {
        yield return new WaitForSeconds(10f);
        bowanim.SetTrigger("a1");

        yield return new WaitForSeconds(20f);
        bowanim.SetTrigger("a2");

        yield return new WaitForSeconds(20f);
        bowanim.SetTrigger("a3");
        

        start_new_attack = true;
        Time.timeScale += 0.1f;
       
    }
}
