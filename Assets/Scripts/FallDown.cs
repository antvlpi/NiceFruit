using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    private Animator anim;
    private float speed = 3f;
    private bool flag_blow = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.5)
        {
            Destroy(gameObject, 0.1f);
        }

        if (flag_blow)
        {
            transform.position = transform.position;
            Destroy(gameObject, 0.7f);
            
        }
        else
        {
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }


    }


    void OnTriggerEnter2D(Collider2D obj_blow)
    {
        if (obj_blow.gameObject.name == "Playerr")
        {
            anim.SetBool("BoomBomb",true);
            flag_blow = true;
        }
        else if(obj_blow.gameObject.name=="Floor")
        {
            transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            anim.SetBool("BoomBomb", true);
            flag_blow = true;
        }
    }
}
