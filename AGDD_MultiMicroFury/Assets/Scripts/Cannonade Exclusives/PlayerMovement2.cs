using UnityEngine;

public class PlayerMovement2 : MonoBehaviour {

    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Add rotation and have camera follow.

        if (Input.GetKey("l"))
        {
            //transform.Rotate(Vector3.up * 30 * Time.deltaTime);
        }
        if (Input.GetKey("j"))
        {
            //transform.Rotate(Vector3.up * -30 * Time.deltaTime);
        }
        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
