using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinResetScript : MonoBehaviour {

    [SerializeField]
    private bool isPlayer1;
    [SerializeField]
    private GameObject friendCube;

    private Vector3 ballLoc;
    private Vector3 cubeLoc;
    private Rigidbody rb;
    private Rigidbody rb2;

    // Use this for initialization
    void Start () {
        ballLoc = transform.position;
        cubeLoc = friendCube.transform.position;
        rb = GetComponent<Rigidbody>();
        rb2 = friendCube.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Respawn" && !isPlayer1)
        {
            transform.position = ballLoc;
            friendCube.transform.position = cubeLoc;
            rb.velocity = new Vector3(0, 0, 0);
            rb2.velocity = new Vector3(0, 0, 0);
        }
        if (theCollision.gameObject.tag == "Player" && isPlayer1)
        {
            transform.position = ballLoc;
            friendCube.transform.position = cubeLoc;
            rb.velocity = new Vector3(0, 0, 0);
            rb2.velocity = new Vector3(0, 0, 0);
        }
    }

    void OnCollisionEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Finish" && !isPlayer1)
        {

        }
        if (theCollision.gameObject.tag == "Bullet" && isPlayer1)
        {

        }
    }

}
