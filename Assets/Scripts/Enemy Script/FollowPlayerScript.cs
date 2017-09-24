using UnityEngine;
using System.Collections;

public class FollowPlayerScript : MonoBehaviour
{
	public GameObject EnemyCommanded;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			EnemyCommanded.GetComponent<SlimeController> ().followPlayer = true;
		}
	}
}
