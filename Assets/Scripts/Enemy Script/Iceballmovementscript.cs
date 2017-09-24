using UnityEngine;
using System.Collections;

public class Iceballmovementscript : MonoBehaviour
{
	public GameObject Character;
	public float followspeed;
	// Use this for initialization
	void Start ()
	{
		Character = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, Character.transform.position, followspeed);
	}
}
