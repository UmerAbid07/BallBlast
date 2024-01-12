using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBalloon : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Add Boundary
        if (transform.position.x > 30)
        {
            transform.position = new Vector3(30, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -5f)
        {
            transform.position = new Vector3(-5f, transform.position.y, transform.position.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
