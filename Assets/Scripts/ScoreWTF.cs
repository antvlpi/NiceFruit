using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWTF : MonoBehaviour
{
    public float record1 = 0;
    public Text scoreText;
    public Text scoreText2;
    public Text scoreText3;
    public Text scoreText4;
    public StartStopPlayer pointsClass;
    Dictionary<float, float> score;
    //public float cnt = 1;

    // Start is called before the first frame update
    void Start()
    {
        pointsClass = GetComponent<StartStopPlayer>();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Convert.ToString(pointsClass.points);
        Convert.ToString(pointsClass.points);
        if (pointsClass.points < 3000)
        {
            scoreText2.text = Convert.ToString(3000);
            scoreText3.text = Convert.ToString("1up");
            scoreText4.text = Convert.ToString("2up");
            //Debug.Log(pointsClass.cnt2);
        }
        else if (pointsClass.points >= 3000 && pointsClass.points < 5000)
        {
            //record1 = PlayerPrefs.GetFloat("SetScore");
            //Debug.Log("REcord" + record1);
            scoreText2.text = Convert.ToString(5000);
            scoreText3.text = Convert.ToString("2up");
            scoreText4.text = Convert.ToString("3up");
            //cnt = 0;
        }
        else if (pointsClass.points >= 5000 && Int32.Parse(scoreText2.text) < 7000)
        {
            scoreText2.text = Convert.ToString(7000);
            scoreText3.text = Convert.ToString("3up");
            scoreText4.text = Convert.ToString("4up");
        }
        else if (pointsClass.points >= 7000 && Int32.Parse(scoreText2.text) < 9000)
        {
            scoreText2.text = Convert.ToString(9000);
            scoreText3.text = Convert.ToString("4up");
            scoreText4.text = Convert.ToString("5up");
        }
        else if (pointsClass.points >= 9000 && Int32.Parse(scoreText2.text) < 12000)
        {
            scoreText2.text = Convert.ToString(12000);
            scoreText3.text = Convert.ToString("5up");
            scoreText4.text = Convert.ToString("6up");
        }

        else if (pointsClass.points > 12000)
        {
            scoreText3.text = Convert.ToString("6up");
            scoreText4.text = Convert.ToString("");

        }
        
    }

}
