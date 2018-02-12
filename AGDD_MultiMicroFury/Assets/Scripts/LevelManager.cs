using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    static LevelManager Instance;
    public List<string> levelNames = new List<string>();
    int player1Score;
    int player2Score;

	// Use this for initialization
	void Start () {
        player1Score = 0;
        player2Score = 0;
		if(Instance != null)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
        }
	}

    void ChangeLevel()
    {
        if(levelNames.Count != 0)
        {
            int index = Random.Range(0, levelNames.Count - 1);
            Application.LoadLevel(levelNames[index]);
            levelNames.RemoveAt(index);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
