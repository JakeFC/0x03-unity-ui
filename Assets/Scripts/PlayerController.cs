using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	// Our object's Rigidbody component is assigned to rb
	// in the inspector.
	public Rigidbody rb;
	public float speed = 900f;
	private int score = 0;
	public Text scoreText;
	public Text healthText;
	public Image winLoseBG;
	public Text winLoseText;
	public int health = 5;

    // Update is called once per frame
	void Update()
	{
		if (health == 0)
		{
			Debug.Log("Game Over!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
	// FixedUpdate is used each frame for physics
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

	// Called when an object with Collider is touched.
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Pickup")
		{
			score += 1;
			Destroy(other.gameObject);
			SetScoreText();
		}
		if (other.gameObject.tag == "Trap")
		{
			health -= 1;
			SetHealthText();
		}
		if (other.gameObject.tag == "Goal")
		{
			ShowWinScreen();
		}
	}

	void SetScoreText()
	{
		scoreText.GetComponent<Text>().text = String.Format("Score: {0}", score);
	}

	void SetHealthText()
	{
		healthText.GetComponent<Text>().text = String.Format("Health: {0}", health);
	}

	void ShowWinScreen()
	{
		winLoseBG.gameObject.SetActive(true);
		winLoseText.GetComponent<Text>().text = "You Win!";
		winLoseText.GetComponent<Text>().color = Color.black;
		winLoseBG.GetComponent<Image>().color = Color.green;
	}
}
