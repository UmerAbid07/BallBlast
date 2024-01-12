using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public float hitsToDestroy =1;
    public bool isCollidedBalloon = false;
    public GameObject childBalloon;
    private void Update()
    {
        
        transform.Translate(Vector3.right * 2 * Time.deltaTime);
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
        if (collision.gameObject.CompareTag("Bullet"))
        {
            int n = 0;
            while (n < 3)
            {
                Instantiate(childBalloon, transform.position, transform.rotation);
                n++;
            }
            Destroy(gameObject);

        }
       
    }
    void randomizeDirection()
    {
        int randomDirection = Random.Range(0, 2) * 2 - 1;

        // Apply the chosen direction to the movement
        Vector3 newScale = transform.localScale;
        newScale.x = Mathf.Abs(newScale.x) * randomDirection;
        transform.localScale = newScale;
    }
    private void Start()
    {
        randomizeDirection();
        //hitsToDestroy = Random.Range(2, 8);
        //it should appear in balloon Ui
    }
   
   
}
