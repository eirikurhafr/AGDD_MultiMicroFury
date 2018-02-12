using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public void StartTheGame()
    {
        GameObject manager = GameObject.Find("LevelManager");
        manager.SendMessage("ChangeLevel");
    }
}
