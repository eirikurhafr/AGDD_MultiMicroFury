using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawer : MonoBehaviour {
    public Vector3 location;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter(Collision theCollision)
    {
        //theCollision.position = location;
    }
}
