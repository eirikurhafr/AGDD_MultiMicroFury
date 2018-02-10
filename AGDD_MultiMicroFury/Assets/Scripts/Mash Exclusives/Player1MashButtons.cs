using UnityEngine;

public class Player1MashButtons : MonoBehaviour {

    public string mashButton = "a";
    public int score = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        //Mashing the right button
        if(Input.GetKey(mashButton))
        {
            score++;
            Debug.Log("Player1Mashes");
        }
		
	}

    void changeButton()
    {

    }
}
