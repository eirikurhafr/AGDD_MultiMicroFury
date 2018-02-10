using UnityEngine;

public class Player2MashButtons : MonoBehaviour {

    public string mashButton = "j";
    public int score = 0;

    // Use this for initialization
    void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {

        //Mashing the right button
        if (Input.GetKey(mashButton))
        {
            score++;
            Debug.Log("Player2Mashes");
        }

    }

    void changeButton()
    {

    }
}
