using UnityEngine;
using System.Collections;

public class ItemQuestScript : MonoBehaviour
{
	public GameObject questitem;
	public GameObject questdialogue1;
	public GameObject questdialogue2;
	public GameObject questdialogue3;
	public GameObject questgate;

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
		if (other.gameObject.name == "Player") {
			questitem.SetActive (false);
			questdialogue1.SetActive (false);
			questdialogue2.SetActive (true);
			questdialogue3.SetActive (true);
			questgate.SetActive (true);
		}
	}
}
