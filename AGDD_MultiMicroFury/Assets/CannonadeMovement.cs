using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonadeMovement : MonoBehaviour {

    public Rigidbody rb;
    public GameObject canvas;
    public GameObject winP1Text;
    public GameObject winP2Text;
    public GameObject Music;
    public GameObject otherPlayer;
    public float speed;
    public string leftKey;
    public string rightKey;
    bool gameOver;
    GameObject manager;

    // Use this for initialization
    void Start()
    {
        gameOver = false;
        rb = GetComponent<Rigidbody>();
        manager = GameObject.Find("LevelManager");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
    }

    void PlayerInput()
    {
        if (!gameOver && !otherPlayer.GetComponent<CannonadeMovement>().getGameOver())
        {
            if (Input.GetKey(leftKey))
            {
                rb.AddForce(speed, 0, 0, ForceMode.Impulse);
            }
            if (Input.GetKey(rightKey))
            {
                rb.AddForce(-speed, 0, 0, ForceMode.Impulse);
            }
        }
        else
        {
            if (Input.GetKeyDown("space"))
            {
                manager.SendMessage("ChangeLevel");
            }
        }
    }

    void GameOver()
    {
        if(!gameOver && !otherPlayer.GetComponent<CannonadeMovement>().getGameOver())
        {
            canvas.SetActive(true);
            gameOver = true;
            if (gameObject.name == "Player1")
            {
                winP2Text.SetActive(true);
                Music.SendMessage("StartFadeOut");
                manager.SendMessage("Player2Up");
            }
            else if (gameObject.name == "Player2")
            {
                winP1Text.SetActive(true);
                Music.SendMessage("StartFadeOut");
                manager.SendMessage("Player1Up");
            }
        }
    }

    public bool getGameOver()
    {
        Debug.Log("Shits over");
        return gameOver;
    }
}
