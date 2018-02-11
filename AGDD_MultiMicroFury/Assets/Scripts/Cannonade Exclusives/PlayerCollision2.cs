using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision2 : MonoBehaviour {

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Bullet")
        {
            FindObjectOfType<GameManager>().CompleteLevel();
        }
    }
}
