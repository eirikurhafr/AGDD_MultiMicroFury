using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour {
    public GameObject spawner;
    public GameObject canvas;
    public GameObject winP1Text;
    public GameObject winP2Text;
    public GameObject loseP1Text;
    public GameObject loseP2Text;
    public GameObject Music;
    bool gameOver = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameOver)
        {
            if (Input.GetKeyDown("space"))
            {
                GameObject manager = GameObject.Find("LevelManager");
                manager.SendMessage("ChangeLevel");
            }
        }
    }

    void OnCollisionEnter(Collision theCollision)
    {
        GameObject winText;
        GameObject loseText;
        GameObject manager = GameObject.Find("LevelManager");
        canvas.SetActive(true);
        if(theCollision.gameObject.name == "Player 1" && !gameOver)
        {
            winP1Text.SetActive(true);
            loseP2Text.SetActive(true);
            manager.SendMessage("Player1Up");
            gameOver = true;
        }
        else if(theCollision.gameObject.name == "Player 2" && !gameOver)
        {
            winP2Text.SetActive(true);
            loseP1Text.SetActive(true);
            manager.SendMessage("Player2Up");
            gameOver = true;
        }
        Music.SendMessage("StartFadeOut");
    }
}
