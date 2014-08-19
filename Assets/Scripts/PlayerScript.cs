using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float jumpHeight = 10.0f;
	private bool _landed = false;
	public int score = 0;
	public GUIText scoreDisplay;

	public AudioClip heartGet;
	public AudioClip jump;
	public AudioClip land;

	// Use this for initialization
	void Start () {
		Input.simulateMouseWithTouches = true;
	}

	// Update is called once per frame
	void Update () {
		if (this.rigidbody2D.velocity.y >= -0.01f && this.rigidbody2D.velocity.y <= 0.01f && !_landed) {
			_landed = true;
			audio.PlayOneShot(land);
		}

		if (Input.GetMouseButtonDown(0)) {
			if (_landed) {
				// Jump!
				audio.PlayOneShot(jump);
				this.rigidbody2D.velocity = new Vector3(0.0f, jumpHeight, 0.0f);
			}
		}
		if (Input.GetMouseButtonUp(0)) {
			this.rigidbody2D.velocity = new Vector3(0.0f, this.rigidbody2D.velocity.y * 0.5f, 0.0f);
		}
	}

	void OnTriggerEnter2D(Collider2D c) {
		if (c.gameObject.tag == "Heart") {
			audio.PlayOneShot(heartGet);
			score++;
			scoreDisplay.text = "Score " + score.ToString();
			c.GetComponent<HeartScript>().ResetPosition();
		}
	}

	void OnBecameInvisible() {
		// GAME OVER MAN
	}
}
