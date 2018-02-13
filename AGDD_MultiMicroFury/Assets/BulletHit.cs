using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Player")
        {
            theCollision.gameObject.SendMessage("GameOver");
        }
    }
}
