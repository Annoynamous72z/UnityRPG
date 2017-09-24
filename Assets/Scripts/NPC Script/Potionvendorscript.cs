using UnityEngine;
using System.Collections;

public class Potionvendorscript : MonoBehaviour
{
	public PlayerHealthManager pHM;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		pHM.currentHPpot = pHM.maxHPpot;
	}
}
