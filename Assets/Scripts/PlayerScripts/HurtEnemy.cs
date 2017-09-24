using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HurtEnemy : MonoBehaviour
{

	public int EnemydamageToGive;
	public GameObject damageBurst;
	private GameObject location;
	private UIManager UI;
	private Animator EnemyHp;

	void Start ()
	{
		UI = FindObjectOfType <UIManager> ();
		EnemyHp = GameObject.FindWithTag ("enemyHpslider").GetComponent<Animator> ();
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		
		if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "SpawnedEnemy" || other.gameObject.tag == "Boss") {
			other.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (EnemydamageToGive);
			Instantiate (damageBurst, other.gameObject.transform.position, transform.rotation);
			EnemyHp.SetBool ("isEnemy", true);
			UI.GetComponent<UIManager> ().enemyHealthBar.maxValue = other.gameObject.GetComponent<EnemyHealthManager> ().MaxHealth;
			UI.GetComponent<UIManager> ().enemyHealthBar.value = other.gameObject.GetComponent<EnemyHealthManager> ().CurrentHealth;
		}
	}
}
