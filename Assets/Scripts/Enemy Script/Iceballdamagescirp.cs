using UnityEngine;
using System.Collections;

public class Iceballdamagescirp : MonoBehaviour
{

	public int damageToGive;
	public GameObject damageBurst;
	// Use this for initialization
	void Start ()
	{


	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.name == "Player") {
			other.gameObject.GetComponent < PlayerHealthManager> ().HurtPlayer (damageToGive);
			Instantiate (damageBurst, other.gameObject.transform.position, transform.rotation);
			Destroy (gameObject);
		}
		if (other.gameObject.tag == "Debris") {
			Destroy (gameObject);
		}

	}

}
