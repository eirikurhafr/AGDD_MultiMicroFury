using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

    public Text player1;
    public Text player2;
    public Text whoWon;

    // Use this for initialization
    void Start () {
        GameObject manager = GameObject.Find("LevelManager");
        int p1Score = manager.GetComponent<LevelManager>().getPlayer1Score();
        int p2Score = manager.GetComponent<LevelManager>().getPlayer2Score();

        player1.text = "Player 1 Score: " + p1Score;
        player2.text = "Player 2 Score: " + p2Score;
        if (p1Score > p2Score)
        {
            whoWon.text = "Player 1 Won The Game!";
        }
        else if (p2Score > p1Score)
        {
            whoWon.text = "Player 2 Won The Game!";
        }
        else if (p1Score == p2Score)
        {
            whoWon.text = "It's a tie!";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
