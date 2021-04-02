using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;
    private float minX = -1.53f;
    private float maxX = 1.53f;
    private float skyY = 5.5f;
    private float speed = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("FirstCoroutine", 5f);
        //StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Spawn ()
    {
        while (true)
        {
            Instantiate(bomb, new Vector2(Random.Range(minX, maxX), skyY), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(5, 10));
        }
    }
    void FirstCoroutine()
    {
        StartCoroutine(Spawn());
    }

}
