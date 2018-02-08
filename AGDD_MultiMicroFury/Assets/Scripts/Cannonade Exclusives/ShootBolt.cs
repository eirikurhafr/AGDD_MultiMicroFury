using UnityEngine;

public class ShootBolt : MonoBehaviour {

    public string key;
    public Rigidbody rb;
    public GameObject ammunition;
    public float shootForce = 100f;
    private Vector3 myNewPosition;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //If the fire button is pressed, then open fire!
        if (Input.GetKey(key))
        {
            var newObject = Instantiate(ammunition, rb.transform); //Create the bullet
            newObject.transform.position = myNewPosition;
            newObject.transform.position = rb.position; // Spawn the bullet in the right place

            newObject.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
        } 
		
	}
}
