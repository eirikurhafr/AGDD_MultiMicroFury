using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRaceScript : MonoBehaviour {

    public GameObject Music;
    public GameObject canvas;
    public GameObject winP1Text;
    public GameObject winP2Text;
    public bool isPlayer1;
    private Rigidbody rb;
    private Vector3 forward;
    private Vector3 up;
    public float speed;
    private bool primary;
    private bool canJump;
    private bool primary2;
    bool gameOver = false;



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
        if(!gameOver)
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
        else
        {
            if(Input.GetKeyDown("space"))
            {
                GameObject manager = GameObject.Find("LevelManager");
                manager.SendMessage("ChangeLevel");
            }
        }
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
            gameOver = true;
            canvas.SetActive(true);
            Music.SendMessage("StartFadeOut");
            GameObject manager = GameObject.Find("LevelManager");
            if (isPlayer1)
            {
                manager.SendMessage("Player1Up");
                winP1Text.SetActive(true);
            }
            else
            {
                manager.SendMessage("Player2Up");
                winP2Text.SetActive(true);
            }
        }
    }
}


