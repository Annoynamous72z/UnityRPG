using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
	public GameObject Enemy;
	public bool spawnEnemy = false;
	public int numberofenemies;
	public int MaxEnemies;


		


	void Update ()
	{
	
		if (numberofenemies < MaxEnemies) {
			spawnEnemy = true;
			if (spawnEnemy == true) {
				numberofenemies = numberofenemies + 1;
			}

		} else {
			spawnEnemy = false;
		}
		if (spawnEnemy) {
			var clone = Instantiate (Enemy, gameObject.transform.position, Quaternion.Euler (Vector3.zero));
		}
	}
	
}
	

