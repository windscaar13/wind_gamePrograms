
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacles")
        {
            Debug.Log("We hit an obstacle!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
