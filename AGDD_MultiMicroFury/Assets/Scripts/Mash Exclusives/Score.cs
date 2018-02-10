using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public Player1MashButtons player1;
    public Player2MashButtons player2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void EndGame()
    {
        if(player2.score < player1.score)
        {

        }
        else if(player1.score < player2.score)
        {

        }
        else
        {

        }
    }
}
