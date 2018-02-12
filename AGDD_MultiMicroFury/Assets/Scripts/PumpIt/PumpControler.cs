using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpControler : MonoBehaviour
{
    public GameObject Music;
    public GameObject canvas;
    public GameObject winP1Text;
    public GameObject winP2Text;
    public bool isPlayer1;
    private Rigidbody rb;
    private Vector3 up;
    public float speed;
    bool gameOver = false;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        up = new Vector3(0, 75, 0);
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
            if (Input.GetKeyDown("space"))
            {
                GameObject manager = GameObject.Find("LevelManager");
                manager.SendMessage("ChangeLevel");
            }
        }
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
