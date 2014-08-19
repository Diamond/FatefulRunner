using UnityEngine;
using System.Collections;

public class BuildingSpawnerScript : MonoBehaviour {
	public Transform buildingPrefab;
	public float spawnInterval = 1.0f;

	public float lastSpawn = 0.0f;

	void Start() {
		lastSpawn = Time.time;
	}

	void Update() {
		if (Time.time - lastSpawn >= spawnInterval) {
			// Spawn new building
			var newBuilding = Instantiate(buildingPrefab) as Transform;
			newBuilding.position = new Vector2(10.0f, Random.Range(-7.0f, -2.0f));
			newBuilding.parent = this.transform;
			// Record time
			lastSpawn = Time.time;
		}
	}
}
