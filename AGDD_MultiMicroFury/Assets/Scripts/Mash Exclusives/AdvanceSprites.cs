using UnityEngine;

public class AdvanceSprites : MonoBehaviour {

    public GameObject sprite1;
    public GameObject sprite2;
    public Player1MashButtons player1;
    public Player2MashButtons player2;
    public float advance;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Check on if player 1 presses the right button.
        //Then advance or backtrack progress sprite.

        if (Input.GetKeyDown(player1.mashButton))
        {
            sprite1.transform.position += Vector3.right * advance;
        }
        else if(Input.anyKeyDown && (!Input.GetKeyDown(player1.mashButton) && !Input.GetKeyDown("j") && !Input.GetKeyDown("k") && !Input.GetKeyDown("l")))
        {
            sprite1.transform.position -= Vector3.right * advance;
        }

        //Do same for player 2

        if (Input.GetKeyDown(player2.mashButton))
        {
            sprite2.transform.position += Vector3.right * advance;
        }
        else if (Input.anyKeyDown && (!Input.GetKeyDown(player2.mashButton) && !Input.GetKeyDown("a") && !Input.GetKeyDown("s") && !Input.GetKeyDown("d")))
        {
            sprite2.transform.position -= Vector3.right * advance;
        }
    }
}
