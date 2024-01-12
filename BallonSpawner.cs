using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonSpawner : MonoBehaviour
{
    public GameObject balloon;
    float xMinRange = -2f;
    float xMaxRange = 29f;
    public int delayAfterSec = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner", 2, delayAfterSec);        
    }

    void spawner()
    {
        float randomX =Random.Range(xMinRange, xMaxRange);
        transform.position = new Vector3(randomX, 9, 0);
        Instantiate(balloon, transform.position, transform.rotation);
    }

}
