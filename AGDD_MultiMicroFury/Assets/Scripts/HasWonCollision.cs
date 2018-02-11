using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasWonCollision : MonoBehaviour {

    private void OnTriggerStart(Collider other)
    {
        if (other.GetComponent<BallController>())
        {
            if (other.GetComponent<BallController>().isPlayer1)
            {
                Debug.Log("Player2 wins");
            }
            else
            {
                Debug.Log("Player1 wins");
            }
        }
        else
        {
            Debug.Log("sdfsdf");
        }
    }
}
