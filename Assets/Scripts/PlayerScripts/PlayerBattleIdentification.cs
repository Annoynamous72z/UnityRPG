using UnityEngine;
using System.Collections;

public class PlayerBattleIdentification: MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D detection)
	{	
		if (detection.gameObject.tag == "Player") {
			Debug.Log ("A meme has occured");
		}
	}
}
