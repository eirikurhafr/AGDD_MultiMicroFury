using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    static LevelManager Instance;
    public List<string> levelNames = new List<string>();
    public int player1Score;
    public int player2Score;
    AsyncOperation asyncLoadLevel;

    // Use this for initialization
    void Start () {
        player1Score = 0;
        player2Score = 0;
		if(Instance != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
        }
	}

    void ChangeLevel()
    {
        if(levelNames.Count != 0)
        {
            int index = Random.Range(0, levelNames.Count - 1);
            Application.LoadLevel(levelNames[index]);
            levelNames.RemoveAt(index);
        }
        else
        {
            asyncLoadLevel = SceneManager.LoadSceneAsync("EndScreen", LoadSceneMode.Single);
            while (!asyncLoadLevel.isDone)
            {
                print("Loading the Scene");
            }
            Text player1Text = GameObject.Find("Player1Text").GetComponent<Text>();
            Text player2Text = GameObject.Find("Player2Text").GetComponent<Text>();
            Text whoWonText = GameObject.Find("WhoWon").GetComponent<Text>();
            player1Text.text = "Player 1 Score: " + player1Score;
            player2Text.text = "Player 2 Score: " + player2Score;
            if(player1Score > player2Score)
            {
                whoWonText.text = "Player 1 Won The Game!";
            }
            else if(player2Score > player1Score)
            {
                whoWonText.text = "Player 2 Won The Game!";
            }
            else if(player1Score == player2Score)
            {
                whoWonText.text = "It's a tie!";
            }
        }
    }

    void Player1Up()
    {
        player1Score++;
    }

    void Player2Up()
    {
        player2Score++;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
