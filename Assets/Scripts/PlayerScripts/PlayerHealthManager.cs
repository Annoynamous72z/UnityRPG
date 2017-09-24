using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour
{
	public GameObject deathText;
	public float waitToReload;
	public double playerMaxHealth;
	public double playerCurrentHealth;
	Animator anim;
	public float minTime = 3f;
	public Rigidbody2D rbody;
	public int maxHPpot;
	public int currentHPpot;
	public PlayerMovement movement;

	void Start ()
	{
		rbody = GetComponent<Rigidbody2D> ();
		playerCurrentHealth = playerMaxHealth;
		anim = GetComponent<Animator> ();
		currentHPpot = maxHPpot;
	}

	IEnumerator timer (float seconds)
	{
		yield return new WaitForSeconds (seconds);
		SceneManager.LoadScene ("MainWorldMap");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (playerCurrentHealth <= 0) {
			movement.enabled = false;
			anim.SetBool ("iswalking", false);
			anim.SetBool ("isHeavyattacking", false);
			anim.SetBool ("isDying", true);	
			deathText.SetActive (true);
			StartCoroutine (timer (minTime));
		}
		if (Input.GetKeyDown (KeyCode.X) || Input.GetKeyDown (KeyCode.K)) {
			if (currentHPpot <= 0) {
				currentHPpot = 0;

			} else if (playerCurrentHealth > 0) {
				playerCurrentHealth = playerCurrentHealth + (0.5 * playerMaxHealth);
				currentHPpot = currentHPpot - 1;
				if (playerCurrentHealth > playerMaxHealth) {
					playerCurrentHealth = playerMaxHealth;
				}

			}
		}
	}



	public void HurtPlayer (int damageToGive)
	{
		if (playerCurrentHealth <= 0) {
			playerCurrentHealth = 0;
		} else {
			playerCurrentHealth -= damageToGive;
		}

	}

	public void SetMaxHealth ()
	{
		playerCurrentHealth = playerMaxHealth;
	}
}

