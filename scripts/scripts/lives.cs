using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lives : MonoBehaviour
{
    public TextMeshProUGUI livesaved1;
    public TextMeshProUGUI scoretext;

    // Start is called before the first frame update
    void Start()
    {
        scoretext = GameObject.Find("scoremind").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        livesaved1.text = scoretext.text;
    }
}
