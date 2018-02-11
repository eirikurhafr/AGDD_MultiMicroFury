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

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision theCollision)
    {
        GameObject winText;
        GameObject loseText;
        canvas.SetActive(true);
        if(theCollision.gameObject.name == "Player 1")
        {
            winP1Text.SetActive(true);
            loseP2Text.SetActive(true);
        }
        else
        {
            winP2Text.SetActive(true);
            loseP1Text.SetActive(true);
        }
        Music.SendMessage("StartFadeOut");
    }
}
