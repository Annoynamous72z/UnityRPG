using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour
{
	public GameObject Gate;
	public GameObject dragondialog;
	public GameObject endgame;
	public int MaxHealth;
	public int CurrentHealth;
	public EnemySpawner Spawner;
	private PlayerStats thePlayerStats;
	public int expToGive;
	private Animator EnemyHp;
	PlayerStats player;

	void Start ()
	{
		CurrentHealth = MaxHealth;
		thePlayerStats = FindObjectOfType<PlayerStats> ();
		EnemyHp = GameObject.FindWithTag ("enemyHpslider").GetComponent<Animator> ();
		player = FindObjectOfType <PlayerStats> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (CurrentHealth <= 0) {
			thePlayerStats.AddExperience (expToGive);
			EnemyHp.SetBool ("isEnemy", false);
			Destroy (gameObject);
			GameObject[] iceballs = GameObject.FindGameObjectsWithTag ("projectile"); 
			foreach (GameObject iceball in iceballs)
				Destroy (iceball);
			if (gameObject.tag == "Boss") {
				Gate.SetActive (true);
				dragondialog.SetActive (false);
				endgame.SetActive (true);
				player.currentLevel = 99;
			}
		}

	}



	public void HurtEnemy (int damageToGive)
	{
		CurrentHealth -= damageToGive;

	}

	public void SetMaxHealth ()
	{
		CurrentHealth = MaxHealth;
	}
	
}
