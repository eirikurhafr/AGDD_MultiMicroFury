using UnityEngine;

public class ShootBolt : MonoBehaviour {

    public string key;
    public Rigidbody rb;
    public GameObject ammunition;
    public float shootForce = 100f;
    public float distance;
    public float cooldownMax; // set this in the editor
    private float cooldownCounter;

    // Use this for initialization
    void Start () {
        cooldownCounter = cooldownMax;
    }
	
	// Update is called once per frame
	void Update () {

        cooldownCounter -= Time.deltaTime;

        if (cooldownCounter < 0)

        {
            cooldownCounter = cooldownMax;
            //If the fire button is pressed, then open fire!
            if (Input.GetKey(key))
            {
                var newObject = Instantiate(ammunition, rb.transform); //Create the bullet
                newObject.transform.position = rb.position + rb.transform.forward * distance; // Spawn the bullet in the right place

                newObject.transform.LookAt(newObject.transform, transform.up);
                newObject.GetComponent<Rigidbody>().AddForce(transform.up * shootForce);
            }
        }
	}
}
