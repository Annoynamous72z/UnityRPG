using UnityEngine;
using System.Collections;

public class EyeballController : MonoBehaviour
{

	public float moveSpeed;

	private Rigidbody2D myRigidbody;
	private bool moving;
	public float timeBetweenMove;
	public float timeToMove;
	private Vector3 moveDirection;
	private float timeBetweenMoveCounter;
	private float timeToMoveCounter;
	public bool followPlayer = false;
	public GameObject Character;



	void Start ()
	{
		myRigidbody = GetComponent<Rigidbody2D> ();
		//timeBetweenMoveCounter = timeBetweenMove;
		//timeToMoveCounter = timeToMove;
		Character = GameObject.Find ("Player");
		timeBetweenMoveCounter = Random.Range (timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
		timeToMoveCounter = Random.Range (timeToMove * 0.75f, timeToMove * 1.25f);
	}

	void Update ()
	{
		if (!followPlayer) {
			if (moving) {
				timeToMoveCounter -= Time.deltaTime;
				myRigidbody.velocity = moveDirection;

				if (timeToMoveCounter < 0f) {
					moving = false;
					//timeBetweenMoveCounter = timeBetweenMove;
					timeBetweenMoveCounter = Random.Range (timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
				}				
			} else {
				timeBetweenMoveCounter -= Time.deltaTime;
				myRigidbody.velocity = Vector2.zero;
				if (timeBetweenMoveCounter < 0f) {
					moving = true;
					//timeToMoveCounter = timeToMove;
					timeToMoveCounter = Random.Range (timeToMove * 0.75f, timeToMove * 1.25f);
					moveDirection = new Vector3 (Random.Range (-1f, 1f) * moveSpeed, Random.Range (-1f, 1f) * moveSpeed, 0f);
				}
			}
		} else {
			transform.position = Vector3.MoveTowards (transform.position, Character.transform.position, 0.01f);


		}
		if (Vector3.Distance (transform.position, Character.transform.position) > 10) {
			followPlayer = false;
		}


	}
}
