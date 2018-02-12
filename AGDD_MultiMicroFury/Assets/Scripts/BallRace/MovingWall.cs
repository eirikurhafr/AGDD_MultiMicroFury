using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour {

    private float maxY = 6f;
    private float minY = 0f;
    private bool goingUp;
    private Vector3 moveV;


    // Use this for initialization
    void Start () {
        if (transform.position.y >= maxY) {
            goingUp = false;
        }
        if (transform.position.y <= minY)
        {
            goingUp = true;
        }
        moveV = new Vector3(0, 0.1f, 0);
    }
	
	// Update is called once per frame
	void Update () {
	    if (transform.position.y >= maxY)
	    {
	        goingUp = false;
	    }
	    if (transform.position.y <= minY)
	    {
	        goingUp = true;
	    }

	    moveWall();
	}

    private void moveWall() {
        if (goingUp) {
            transform.position += moveV;
        } else {
            transform.position -= moveV;
        }
    }
}
