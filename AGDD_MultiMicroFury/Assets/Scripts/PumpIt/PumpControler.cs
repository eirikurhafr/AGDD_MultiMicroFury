using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpControler : MonoBehaviour
{

    public bool isPlayer1;
    private Rigidbody rb;
    private Vector3 up;
    public float speed;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        up = new Vector3(0, 75, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            moveCharacter1();
        }
        else
        {
            moveCharacter2();
        }
        hasLost();
    }

    private void moveCharacter1()
    {

        if (Input.GetKeyDown("s"))
        {
            rb.AddForce(up);
        }


    }

    private void moveCharacter2()
    {
        if (Input.GetKeyDown("k"))
        {
            rb.AddForce(up);
        }
    }


    void hasLost()
    {
        if (transform.position.y >= 7.345)
        {
            if (isPlayer1)
            {
                Debug.Log("Player2 wins");
            }
            else
            {
                Debug.Log("Player1 wins");
            }
        }
    }
}
