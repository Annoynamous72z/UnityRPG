using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
	public int currentLevel;
	public double currentExp;
	public double tolevelup = 25;
	private PlayerHealthManager MaxHp;
	private HurtEnemy Attack;
	public GameObject knight;

	// Use this for initialization
	void Start ()
	{
		MaxHp = FindObjectOfType <PlayerHealthManager> ();
		Attack = FindObjectOfType<HurtEnemy> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (currentExp >= tolevelup) {
			currentLevel++;
			currentExp = currentExp - tolevelup;
			tolevelup = tolevelup * 1.25;
			MaxHp.playerMaxHealth = MaxHp.playerMaxHealth + 25;
			MaxHp.playerCurrentHealth = MaxHp.playerMaxHealth;
			Attack.EnemydamageToGive = Attack.EnemydamageToGive + 2;
		}
		if (currentLevel >= 5) {
			knight.SetActive (true);	
		}
	}

	public void AddExperience (int experienceToAdd)
	{
		currentExp += experienceToAdd;
	}
}
