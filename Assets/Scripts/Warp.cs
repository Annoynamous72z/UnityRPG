using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour
{
	public Transform warpTarget;
	public GameObject destroyedmap;

	IEnumerator OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			ScreenFader sf = GameObject.FindGameObjectWithTag ("Fader").GetComponent<ScreenFader> ();
			yield return StartCoroutine (sf.FadetoBlack ());

			Destroy (destroyedmap);
			GameObject[] enemies = GameObject.FindGameObjectsWithTag ("SpawnedEnemy"); 
			if (destroyedmap != null) {
				foreach (GameObject enemy in enemies)
					Destroy (enemy);
				Destroy (GameObject.FindGameObjectWithTag ("SpawnedEnemy"));
			}
			other.gameObject.transform.position = warpTarget.position;
			Camera.main.transform.position = warpTarget.position;

			yield return StartCoroutine (sf.FadeToClear ());
		}


	}
	

}
