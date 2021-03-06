﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public GameObject Music;
    public GameObject canvas;
    public GameObject winP1Text;
    public GameObject winP2Text;
    public bool isPlayer1;
    private Rigidbody rb;
    private Vector3 forwardV;
    private Vector3 backwardsV;
    private Vector3 leftV;
    private Vector3 rightV;
    public float speed;
    bool gameOver = false;


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
        if(!gameOver)
        {
            if (isPlayer1)
            {
                moveCharacter1(forwardV, backwardsV, leftV, rightV);
            }
            else
            {
                moveCharacter2(forwardV, backwardsV, leftV, rightV);
            }
            hasLost();
        }
        else
        {
            if (Input.GetKeyDown("space"))
            {
                GameObject manager = GameObject.Find("LevelManager");
                manager.SendMessage("ChangeLevel");
            }
        }
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
            Music.SendMessage("StartFadeOut");
            GameObject manager = GameObject.Find("LevelManager");
            canvas.SetActive(true);
            if (isPlayer1)
            {
                manager.SendMessage("Player2Up");
                winP2Text.SetActive(true);
            }
            else
            {
                manager.SendMessage("Player1Up");
                winP1Text.SetActive(true);
            }
            gameOver = true;
        }
    }
}
