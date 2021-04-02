using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public GameObject[] fruits;
    private float minX = -1.53f;
    private float maxX = 1.53f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator spawn()
    {
        while (true)
        {
            int rand = Random.Range(0, fruits.Length - 1);
            Instantiate(fruits[rand], new Vector2(Random.Range(minX, maxX), 5.7f), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1, 2));
           
        }
    }
}
