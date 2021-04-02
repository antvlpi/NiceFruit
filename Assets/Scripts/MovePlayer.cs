using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform posPlayer;
    [SerializeField]
    private float speed = 20f;
    private float minX = -1.53f;
    private float maxX = 1.53f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void OnMouseDrag ()
    {
        Vector3 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (posMouse.x < minX)
        {
            posMouse.x = minX;
        }
        else if (posMouse.x > maxX)
        {
            posMouse.x = maxX;
        }
        posPlayer.position = Vector2.MoveTowards (posPlayer.position, new Vector2(posMouse.x, posPlayer.position.y), speed * Time.deltaTime);
    }
}
