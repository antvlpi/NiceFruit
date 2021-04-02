using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartStopPlayer : MonoBehaviour
{
    private Animator start_stop_player; 
    public Health heartsss;
    public float points;
    public float p;
    public FallDown _fallDawn;
    public float cnt2;
    public bool saveRecord = false;
    // Start is called before the first frame update
    void Start()
    {
        start_stop_player = GetComponent<Animator>();
        heartsss = GetComponent<Health>();
        _fallDawn = GetComponent<FallDown>();
    }

    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(points);

    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "FruitTag")
        {
            start_stop_player.SetBool("StopStart", true);
            points += 200f;
        }
        else if (collision.gameObject.tag == "BombTag")
        {
            GameObject _bombPos = GameObject.FindWithTag("BombTag");
            if (heartsss.hearts.Count !=0  && _bombPos.transform.localScale  !=  new Vector3(0.2f, 0.2f, 0.2f))
            {
                Destroy(heartsss.hearts[heartsss.hearts.Count - 1]);
                heartsss.hearts.RemoveAt(heartsss.hearts.Count - 1);
                if (heartsss.hearts.Count==0)
                {
                    p = points;
                    saveRecord = true;
                    SceneManager.LoadScene("SampleScene3");
                    
                }
            }
        }
    }
    
    void animEnd()
    {
        start_stop_player.SetBool("StopStart", false);
    }
    
    
}
