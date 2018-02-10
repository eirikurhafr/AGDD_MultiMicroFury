using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGameManager : MonoBehaviour {

    public bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void Update()
    {
        if (Input.GetKey("r") || Input.GetKeyDown("space"))
        {
            Invoke("Restart", restartDelay);
        }
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER.");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("Level Won!");
    }

    public void GoToNextLevel()
    {
        Debug.Log("Button pressed.");
        //SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
    }
}
