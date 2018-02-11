using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreNumber : MonoBehaviour {

    public Player1MashButtons player1;
    public Player2MashButtons player2;
    public Text scoreNumber;
    public Text scoreNumber2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreNumber.text = player1.score.ToString();
        scoreNumber2.text = player2.score.ToString();
    }
}
