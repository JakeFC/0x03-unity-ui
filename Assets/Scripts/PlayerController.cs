using UnityEngine;

public class PlayerController : MonoBehaviour
{
	// Our object's Rigidbody component is assigned to rb
	// in the inspector.
	public Rigidbody rb;
	public float speed = 900f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
		{
			rb.AddForce(0, 0, speed * Time.deltaTime);
		}
		if (Input.GetKey("s"))
		{
			rb.AddForce(0, 0, -speed * Time.deltaTime);
		}
		if (Input.GetKey("d"))
		{
			rb.AddForce(speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey("a"))
		{
			rb.AddForce(-speed * Time.deltaTime, 0, 0);
		}
    }
}
