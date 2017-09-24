using UnityEngine;
using System.Collections;

public class NPCmovement : MonoBehaviour
{
	public float movespeed;
	private Rigidbody2D myRigidbody;
	public bool iswalking;
	public float walkTime;
	private float walkCounter;
	public float waitTime;
	private float waitCounter;
	private int WalkDirection;
	private Animator anim;
	// Use this for initialization
	void Start ()
	{
		myRigidbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent <Animator> ();
		waitCounter = waitTime;
		walkCounter = walkTime;
		ChooseDirection ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (iswalking) {
			walkCounter -= Time.deltaTime;

			switch (WalkDirection) {
			case 0:
				anim.SetBool ("isWalk", true);
				myRigidbody.velocity = new Vector2 (0, movespeed);
				break;
			case 1:
				anim.SetBool ("isWalk", true);
				myRigidbody.velocity = new Vector2 (movespeed, 0);
				break;
			case 2:
				anim.SetBool ("isWalk", true);
				myRigidbody.velocity = new Vector2 (0, -movespeed);
				break;
			case 3:
				anim.SetBool ("isWalk", true);
				myRigidbody.velocity = new Vector2 (-movespeed, 0);
				break;
			}
			if (walkCounter < 0) {
				anim.SetBool ("isWalk", false);
				myRigidbody.velocity = new Vector2 (0, 0);
				iswalking = false;
				waitCounter = waitTime;
			}

		} else {
			waitCounter -= Time.deltaTime;
			if (waitCounter < 0) {
				ChooseDirection ();


			}
		}
	}

	public void ChooseDirection ()
	{
		WalkDirection = Random.Range (0, 4);
		switch (WalkDirection) {
		case 0:
			anim.SetBool ("isUp", true);
			anim.SetBool ("isLeft", false);
			anim.SetBool ("isRight", false);
			anim.SetBool ("isDown", false);
			break;
		case 1:
			anim.SetBool ("isUp", false);
			anim.SetBool ("isLeft", false);
			anim.SetBool ("isRight", true);
			anim.SetBool ("isDown", false);
			break;
		case 2:
			anim.SetBool ("isUp", false);
			anim.SetBool ("isLeft", false);
			anim.SetBool ("isRight", false);
			anim.SetBool ("isDown", true);
			break;
		case 3:
			anim.SetBool ("isUp", false);
			anim.SetBool ("isLeft", true);
			anim.SetBool ("isRight", false);
			anim.SetBool ("isDown", false);
			break;
		}
		iswalking = true;
		walkCounter = walkTime;

	}
}
