using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToStartScene : MonoBehaviour {
    public string sceneName;

    public void startTheGame()
    {
        Application.LoadLevel(sceneName);
    }
}
