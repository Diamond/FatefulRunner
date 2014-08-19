using UnityEngine;
using System.Collections;

public class HeartScript : MonoBehaviour {
	public float speed = 0.3f;

	// Update is called once per frame
	void Update () {
		this.transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
	}

	public void ResetPosition() {
		this.transform.position = new Vector2(Random.Range (20.0f, 40.0f), Random.Range (0.0f, -5.0f));
	}

	public void OnBecameInvisible() {
		this.ResetPosition();
	}
}
