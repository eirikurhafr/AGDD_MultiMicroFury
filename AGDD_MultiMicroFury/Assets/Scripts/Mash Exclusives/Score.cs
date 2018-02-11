using UnityEngine;

public class Score : MonoBehaviour {

    public Player1MashButtons player1;
    public Player2MashButtons player2;

    // Use this for initialization
    void Start () {
        Invoke("EndGame()", 61.0f);
	}

    void EndGame()
    {
        if(player2.score < player1.score)
        {
            FindObjectOfType<GameManager>().CompleteLevel();
        }
        else if(player1.score < player2.score)
        {
            FindObjectOfType<GameManager>().CompleteLevel2();
        }
        else
        {
            FindObjectOfType<GameManager>().CompleteLevel3();
        }
    }
}
