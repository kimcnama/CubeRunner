using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        Debug.Log("Game Started\n");
	}

    public float forwardForce = 1000f;
    public float dodgeForce = 100f;

	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Time Delta manages frame rate

        if (Input.GetKey("."))
        {
            rb.AddForce(dodgeForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(","))
        {
            rb.AddForce(-dodgeForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
	}
}
