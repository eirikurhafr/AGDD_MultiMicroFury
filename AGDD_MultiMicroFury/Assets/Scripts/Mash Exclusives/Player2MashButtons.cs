using UnityEngine;

public class Player2MashButtons : MonoBehaviour {

    public GameObject scoreText;
    public GameObject mashText;
    public string mashButton = "j";
    public int score = 0;
    private float changeTimer;
    private float changeSwitch;

    // Use this for initialization
    void Start ()
    {
        changeSwitch = Random.Range(1.0f, 9.0f);
        changeTimer = Random.Range(1.0f, 10.0f);
    }

    void changeButton()
    {
        if (changeSwitch <= 3.0f)
        {
            mashButton = "j";
        }
        else if (3.0f < changeSwitch && changeSwitch <= 6.0f)
        {
            mashButton = "k";
        }
        else
        {
            mashButton = "l";
        }

        changeTimer = Random.Range(1.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        changeTimer = changeTimer - (1.0f * Time.deltaTime);

        if (changeTimer <= 0)
        {
            changeButton();
        }

        //Mashing the right button
        if (Input.GetKeyDown(mashButton))
        {
            score++;
            Debug.Log("Player2Mashes");
        }

    }
}
