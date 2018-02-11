using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeWayMovePlayer : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public float jump;
    public string jumpKey;
    public string forwardKey;
    public string backwardsKey;
    bool canJump;

    // Use this for initialization
    void Start()
    {
        canJump = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        GoingDown();
    }

    void PlayerInput()
    {
        if (Input.GetKey(forwardKey) && canJump)
        {
            rb.AddForce(speed, 0, 0, ForceMode.Impulse);
        }
        else if (Input.GetKey(forwardKey) && !canJump)
        {
            rb.AddForce(speed / 2, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetKey(backwardsKey) && canJump)
        {
            rb.AddForce(-speed, 0, 0, ForceMode.Impulse);
        }
        else if (Input.GetKey(backwardsKey) && !canJump)
        {
            rb.AddForce(-speed / 2, 0, 0, ForceMode.Impulse);
        }


        if (Input.GetKey(jumpKey) && canJump)
        {
            rb.AddForce(speed * 2, jump, 0, ForceMode.Impulse);
            canJump = false;
        }
    }

    void GoingDown()
    {
        if (rb.velocity.y < 0)
        {
            float tala = rb.velocity.y * 0.065f;
            rb.AddForce(0, tala, 0, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Floor")
        {
            canJump = true;
        }
    }

    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Floor")
        {
            canJump = false;
        }
    }

    void Respawn(Vector3 location)
    {
        rb.position = location;
    }
}
