using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuRecord : MonoBehaviour
{
    private float[] record1 = new float[3];
    public Text[] textRecord= new Text[3];
    // Start is called before the first frame update
    void Start()
    {
        LoadRecord2();
        for (int i = 0; i<= textRecord.Length-1;++i)
        {
            textRecord[i].text = Convert.ToString(record1[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LoadRecord2()
    {
        List<float> tmp = new List<float>();
        for (int j = 0; PlayerPrefs.HasKey("SetScore2" + j) == true; j++)
        {
            tmp.Add(PlayerPrefs.GetFloat("SetScore2" + j));
        }
        for (int i = 0; i < tmp.Count; i++)
        {
            record1[i] = tmp[i];

        }
    }
}
