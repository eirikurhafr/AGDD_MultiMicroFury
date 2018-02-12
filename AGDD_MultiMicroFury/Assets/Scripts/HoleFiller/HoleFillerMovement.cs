using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleFillerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public string upKey;
    public string leftKey;
    public string rightKey;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PlayerInput();
	}

    void PlayerInput()
    {
        if (Input.GetKey(leftKey))
        {
            rb.AddTorque(0, 0, speed);
        }
        if (Input.GetKey(rightKey))
        {
            rb.AddTorque(0, 0, -speed);
        }
        if (Input.GetKey(upKey))
        {
            rb.AddTorque(speed, 0, 0);
        }
        if (Input.GetKey(leftKey) && Input.GetKey(rightKey))
        {
            rb.AddTorque(-speed, 0, 0);
        }
    }
}
