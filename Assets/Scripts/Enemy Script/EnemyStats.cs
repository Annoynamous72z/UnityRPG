using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour
{
	private PlayerStats playerlevel;
	public int enemyLevel;

	void Start ()
	{
		playerlevel = GetComponent <PlayerStats> ();
	}
	// Update is called once per frame
	void Update ()
	{
		playerlevel = GetComponent <PlayerStats> ();
		enemyLevel = playerlevel.currentLevel;
	}
}
