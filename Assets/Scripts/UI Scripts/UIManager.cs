using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public Slider healthBar;
	public Slider enemyHealthBar;
	public Slider expBar;
	public Text HPText;
	public PlayerHealthManager playerHealth;
	public Text levelText;
	private PlayerStats thePS;
	public EnemyHealthManager enemyHealth;
	public Text HPpot;

	// Use this for initialization
	void Start ()
	{
		thePS = GetComponent <PlayerStats> ();
		enemyHealth = FindObjectOfType <EnemyHealthManager> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		expBar.maxValue = (float)thePS.tolevelup;
		expBar.value = (float)thePS.currentExp;
		healthBar.maxValue = (float)playerHealth.playerMaxHealth;
		healthBar.value = (float)playerHealth.playerCurrentHealth;
		HPText.text = "Health: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
		HPpot.text = "HP Potions Left: " + playerHealth.currentHPpot + "/" + playerHealth.maxHPpot;
		levelText.text = "Level: " + thePS.currentLevel;
	}
}
