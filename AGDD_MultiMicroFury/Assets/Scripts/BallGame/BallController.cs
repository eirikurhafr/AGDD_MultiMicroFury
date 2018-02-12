using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public bool isPlayer1;
    private Rigidbody rb;
    private Vector3 forwardV;
    private Vector3 backwardsV;
    private Vector3 leftV;
    private Vector3 rightV;
    public float speed;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();

        if (isPlayer1)
        {
            forwardV = new Vector3(speed, 0, 0);
            backwardsV = new Vector3(-speed, 0, 0);   
        }else{
            forwardV = new Vector3(-speed, 0, 0);
            backwardsV = new Vector3(speed, 0, 0);
        }


        leftV = new Vector3(0, 0, speed);
        rightV = new Vector3(0, 0, -speed);

    }
	
	// Update is called once per frame
	void Update () {
        if (isPlayer1){
            moveCharacter1(forwardV, backwardsV, leftV, rightV);
        } else{
            moveCharacter2(forwardV, backwardsV, leftV, rightV);
        }
        hasLost();
    }

    private void moveCharacter1(Vector3 forward, Vector3 backwards, Vector3 left, Vector3 right)
    {
        if (Input.GetKey("a"))
        {
            rb.AddForce(left);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(forward);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(right);
        }
        if (Input.GetKey("a") && Input.GetKey("d"))
        {
            rb.AddForce(backwards);
        }

    }

    private void moveCharacter2(Vector3 forward, Vector3 backwards, Vector3 left, Vector3 right)
    {
        if (Input.GetKey("j"))
        {
            rb.AddForce(left);
        }
        if (Input.GetKey("k"))
        {
            rb.AddForce(forward);
        }
        if (Input.GetKey("l"))
        {
            rb.AddForce(right);
        }
        if (Input.GetKey("j") && Input.GetKey("l"))
        {
            rb.AddForce(backwards);
        }
    }


    void hasLost()
    {
        if(transform.position.y <= 0)
        {
            GameObject manager = GameObject.Find("LevelManager");
            if (isPlayer1)
            {
                Debug.Log("Player2 wins");
            }
            else
            {
                Debug.Log("Player1 wins");
            }
            manager.SendMessage("ChangeLevel");
        }
    }
}
