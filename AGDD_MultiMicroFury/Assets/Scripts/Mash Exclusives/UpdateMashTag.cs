using UnityEngine;
using UnityEngine.UI;

public class UpdateMashTag : MonoBehaviour {

    public Player1MashButtons player1;
    public Player2MashButtons player2;
    public Text mashTag;
    public Text mashTag2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mashTag.text = player1.mashButton;
        mashTag2.text = player2.mashButton;
    }
}
