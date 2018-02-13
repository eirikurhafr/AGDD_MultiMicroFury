using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinResetScript : MonoBehaviour {

    [SerializeField]
    private bool isPlayer1;
    [SerializeField]
    private GameObject friendCube;

    public GameObject canvas;
    public GameObject winP1Text;
    public GameObject winP2Text;
    public GameObject Music;
    GameObject manager;

    private Vector3 ballLoc;
    private Vector3 cubeLoc;
    private Rigidbody rb;
    private Rigidbody rb2;
    bool gameOver;

    // Use this for initialization
    void Start () {
        gameOver = false;
        manager = GameObject.Find("LevelManager");
        ballLoc = transform.position;
        cubeLoc = friendCube.transform.position;
        rb = GetComponent<Rigidbody>();
        rb2 = friendCube.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        if (gameOver)
        {
            if (Input.GetKeyDown("space"))
            {
                manager.SendMessage("ChangeLevel");
            }
        }
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

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Finish" && !isPlayer1 && !gameOver)
        {
            canvas.SetActive(true);
            gameOver = true;
            winP2Text.SetActive(true);
            Music.SendMessage("StartFadeOut");
            manager.SendMessage("Player2Up");
        }
        if (theCollision.gameObject.tag == "Bullet" && isPlayer1 && !gameOver)
        {
            canvas.SetActive(true);
            gameOver = true;
            winP1Text.SetActive(true);
            Music.SendMessage("StartFadeOut");
            manager.SendMessage("Player1Up");
        }
    }

}
