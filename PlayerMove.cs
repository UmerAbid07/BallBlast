using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public bool gameOver=false;
    public bool horizontalInput;
    public float moveSpeed = 10f;
    public float variable;
    int horizontalInputvalue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (horizontalInput)
        {
            horizontalInputvalue = 1;
        }
        else
        {
            horizontalInputvalue = 0;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler (0, 270, 0);
            horizontalInput = true;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            horizontalInput = true;
        }
        else
        {
            //transform.rotation = Quaternion.Euler(0, 0, 0);
            horizontalInput = false;
        }
        transform.Translate(Vector3.forward * horizontalInputvalue * moveSpeed * Time.deltaTime);

        //restricted range
        if (transform.position.x<-5 )
        {
            transform.position = new Vector3(-5f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 30 )
        {
            transform.position =new Vector3(30,transform.position.y,transform.position.z);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Balloon")
        {
            gameOver=true;
        }
        else if(collision.gameObject.tag=="ChildBalloon")
        {
            gameOver = true;
        }
        else
        {
            gameOver = false;
        }
    }
}
