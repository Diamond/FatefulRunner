using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {
	public float speed = 0.3f;

	// Update is called once per frame
	void Update () {
		this.transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
	}

	void OnBecameInvisible()
	{
		this.transform.position = new Vector2(20.0f, Random.Range(-7.0f, -2.0f));
	}
}
