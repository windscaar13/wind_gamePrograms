using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigidBody;
    public float forwardForce = 1000f;
    public float sidewayForce = 500f;

    public string moveRight = "d";
    public string moveLeft = "a";


    // Update is called once per frame
    // Use FixedUpdate instead of Update when u play with physics
    void FixedUpdate()
    {
        rigidBody.AddForce(0,0, forwardForce * Time.deltaTime);

        if (Input.GetKey(moveLeft))
        {
            rigidBody.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
