using UnityEngine;
using System.Collections;

public class Iceballspawner : MonoBehaviour
{
	public GameObject projectile;
	public float spawnspeed;
	float spawntime;
	bool spawn;

	void Start ()
	{

		spawntime = spawnspeed;
	}
	// Update is called once per frame
	void Update ()
	{
		spawnspeed -= Time.deltaTime;
		if (spawnspeed < 0) {
			spawn = true;
		}
		if (spawn) {
			var clone = Instantiate (projectile, gameObject.transform.position, Quaternion.Euler (Vector3.zero));
			spawn = false;
			spawnspeed = spawntime;
		}
	}
}
