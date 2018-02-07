using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collisionInfo.collider.tag == "Capsule")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
