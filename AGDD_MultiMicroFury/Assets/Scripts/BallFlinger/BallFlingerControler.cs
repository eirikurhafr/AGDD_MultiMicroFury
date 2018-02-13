using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFlingerControler : MonoBehaviour {

    [SerializeField]
    private bool isPlayer1;

    [SerializeField]
    private float speed;

    private Rigidbody rb;
    private Vector3 forceV;

    private Vector3 SquareLoc;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        forceV = new Vector3(0, 0, speed);
        SquareLoc = transform.position;
    }

    // Update is called once per frame
    void Update () {
        swingCatapault();
    }

    void swingCatapault()
    {
        if (Input.GetKey("s") && isPlayer1)
        {
            rb.AddForce(forceV);
        }
        if (Input.GetKey("k") && !isPlayer1)
        {
            rb.AddForce(forceV);
        }
    }
}
