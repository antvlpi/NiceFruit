using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    public float[] record1 = new float[3];
    private float record_temp;
    private StartStopPlayer _p;
    private float _record;
    private float[] _record2 = new float[3];
    public Text _recordText;
    //public Text
    // Start is called before the first frame update
    void Start()
    {
        _p = GetComponent<StartStopPlayer>();
        _recordText.text = PlayerPrefs.GetFloat("SetScore").ToString();
        LoadRecord2();
        //GetComponent<Text>().text = PlayerPrefs.GetFloat("SetScore").ToString();

    }

    // Update is called once per frame
    void Update()
    {
        //LoadRecord2();

        //SelectionSort
        if (_p.saveRecord)
        {
            SelectionSort();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
           // Debug.Log("Delete " + _record);
        }
    }

    
    void SelectionSort()
    {
        LoadRecord();
        if (_record < _p.p)
        {
            SaveRecord();
        }

        if (_p.p > record1[record1.Length - 1])
        {
                record1[record1.Length - 1] = _p.p;
                
                for (int i = 0; i <= record1.Length - 1; i++)
                {
                    for (int j = 0; j <= record1.Length - 1; j++)
                    {
                        if (record1[i] >= record1[j])
                        {
                            record_temp = record1[i];
                            record1[i] = record1[j];
                            record1[j] = record_temp;
                        }
                    }
                }
        }
        SaveRecord2();
        _p.saveRecord = false;
    }


    private void SaveRecord()
    {

        PlayerPrefs.SetFloat("SetScore", _p.p);
        //Debug.Log("Save");
    }
    private void LoadRecord()
    {
        _record = PlayerPrefs.GetFloat("SetScore");
        //Debug.Log("Load " + _record);
    }


    private void SaveRecord2()
    {
        for (int i = 0; i <= record1.Length - 1; i++)

        {
            PlayerPrefs.SetFloat("SetScore2" + i, record1[i]);
            //Debug.Log(record1[i]);
        } 
    }
    private void LoadRecord2()
    {
        List<float> tmp = new List<float>();
        for (int j = 0; PlayerPrefs.HasKey("SetScore2" + j)==true; j++)
        {
            tmp.Add(PlayerPrefs.GetFloat("SetScore2" + j));
        }

        for (int i = 0; i < tmp.Count; i++)

        {
            record1[i]=tmp[i];

        }/*
        foreach (int i in record1)
        {
            Debug.Log(i);
        }*/
    }

}
