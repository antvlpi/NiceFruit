using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSpawn : MonoBehaviour
{
    public Text t;
    float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (t.text == 1+"up")
        {
            speed = 0f;
        }
        else if (t.text==2+"up")
        {
            speed = 0.3f;
        }
        else if (t.text==3+"up")
        {
            speed = 0.6f;
        }
        else if (t.text == 4 + "up")
        {
            speed = 1.2f;
        }
        else if (t.text == 5 + "up")
        {
            speed = 1.5f;
        }
        else
        {
            speed = 2.1f;
        }
    }
}
