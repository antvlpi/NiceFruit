using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDownFruit : MonoBehaviour
{
    private float speed = 3f;
    private Animator anim2;
    private bool flag_stop = false;

    // Start is called before the first frame update
    void Start()
    {
        anim2 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!flag_stop)
        {
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }
        else if (flag_stop)
        {

            transform.position = transform.position;
            Destroy(gameObject, 0.3f);

        }
        /*
        else if (flag_stop2 && flag_stop)
        {
            //Vector3 a = new Vector3(transform.position.x, -4.5f ,0);
            //transform.position = Vector3.MoveTowards(transform.position, a, speed*Time.deltaTime);
            //transform.localScale = new Vector3(1f, 0.12f, 1);
            Destroy(gameObject, 1);

        }
        */
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Playerr" && transform.position.y > -2.47f)
        {
            anim2.SetBool("boom", true);
            flag_stop = true;
        }
        else if (other.gameObject.name == "Floor")
        {
            //if (transform.position.y == -4.3f)
            flag_stop = true;
        }

    }
}
