using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public bool scoreFlag = false;
    void Update()
    {
        //Bullet Movement
        transform.Translate(Vector3.up * 20 * Time.deltaTime);
        //destroy
        if(transform.position.y>10f)
        {
            Destroy(gameObject);
        }
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Balloon"))
        {
            scoreFlag = true;
        }
        else
        {
            scoreFlag = false;
        }
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            scoreFlag = true;
        }else
        {
            scoreFlag = false;
        }
        //needs to work

    }

}
