﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Bullet")
        {
            FindObjectOfType<GameManager>().CompleteLevel2();
        }
    }
}
