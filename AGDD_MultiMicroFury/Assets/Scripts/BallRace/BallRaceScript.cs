using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRaceScript : MonoBehaviour {

    public bool isPlayer1;
    private Rigidbody rb;
    private Vector3 forward;
    private Vector3 up;
    public float speed;
    private bool primary;
    private bool canJump;
    private bool primary2;



    // Use this for initialization
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        forward = new Vector3(speed, 0, 0);
        up = new Vector3(0, 300, 0);
        primary = false;
        primary2 = false;
        canJump = false;
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
        if (Input.GetKeyDown("a"))
        {
            if (primary) {
                rb.AddForce(forward);
                primary = !primary;
            }
        }
        if (Input.GetKeyDown("s") && canJump)
        {
            rb.AddForce(up);
            canJump = false;
        }
        if (Input.GetKeyDown("d"))
        {
            if (!primary)
            {
                rb.AddForce(forward);
                primary = !primary;
            }
        }


    }

    private void moveCharacter2()
    {
        if (Input.GetKeyDown("j"))
        {
            if (primary2)
            {
                rb.AddForce(forward);
                primary2 = !primary2;
            }
        }
        if (Input.GetKeyDown("k") && canJump)
        {
            rb.AddForce(up);
            canJump = false;
        }
        if (Input.GetKeyDown("l"))
        {
            if (!primary2)
            {
                rb.AddForce(forward);
                primary2 = !primary2;
            }
        }
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Floor")
        {
            canJump = true;
        }
    }


    void hasLost()
    {
        if (transform.position.x >= 31.339f)
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


