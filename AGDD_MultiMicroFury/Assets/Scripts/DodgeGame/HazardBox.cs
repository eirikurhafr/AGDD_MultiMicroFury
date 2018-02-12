using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardBox : MonoBehaviour {
    public GameObject canvas;
    public GameObject spawner;
    public GameObject winP1Text;
    public GameObject winP2Text;
    public GameObject Music;
    GameObject manager;
    public bool canBeDestroyed = false;

    void Start()
    {
        manager = GameObject.Find("LevelManager");
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if(theCollision.gameObject.tag == "Player")
        {
            canvas.SetActive(true);
            if (theCollision.gameObject.name == "Player 1" && !winP1Text.active && !winP2Text.active)
            {
                winP2Text.SetActive(true);
                Music.SendMessage("StartFadeOut");
                manager.SendMessage("ChangeLevel");
            }
            else if(theCollision.gameObject.name == "Player 2" && !winP1Text.active && !winP2Text.active)
            {
                winP1Text.SetActive(true);
                Music.SendMessage("StartFadeOut");
                manager.SendMessage("ChangeLevel");
            }
            spawner.SendMessage("TurnOff");
        }
        else if(theCollision.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }
    }
}
