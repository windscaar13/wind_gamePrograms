using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerTransform;
    public Rigidbody rigidBody;
    public float forwardForce = 1000f;
    public float sidewayForce = 500f;
    public float upwardForce = 500f;

    public string moveRight = "d";
    public string moveLeft = "a";

    public bool objInGround = true;


    // Update is called once per frame
    // Use FixedUpdate instead of Update when u play with physics
    void FixedUpdate()
    {
        
        rigidBody.AddForce(0,0, forwardForce * Time.deltaTime);

        if(playerTransform.position.y >= 1.1)
        {
            objInGround = false;
        }
        else
        {
            objInGround = true;
        }

        if (Input.GetKey(moveLeft))
        {
            rigidBody.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (objInGround)
            {
                rigidBody.AddForce(0, upwardForce, 0);
            }
        }
        if(rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
