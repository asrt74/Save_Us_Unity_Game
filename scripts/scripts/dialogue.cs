using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialogue : MonoBehaviour
{
    public TextMeshProUGUI textdisplay;
    public string[] sentences;
    private int index;
    public float typingspeed;

    void Start()
    {
        StartCoroutine(Type());
    }
    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textdisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }
    public void next_sentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            textdisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            // textdisplay.text = "";
            SceneManager.LoadScene("mainmenu");
        }
    }
}
