using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{
	
	public Rigidbody2D rbody;
	public Animator anim;
	// Use this for initialization
	public void Start ()
	{
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
		
	// Update is called once per frame
	public void Update ()
	{
		Vector2 movement_vector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		if (movement_vector != Vector2.zero) {
			anim.SetBool ("iswalking", true);
			anim.SetFloat ("input_x", movement_vector.x);
			anim.SetFloat ("input_y", movement_vector.y);

		} else {
	
			anim.SetBool ("iswalking", false);
		}

		if (Input.GetKey (KeyCode.LeftShift)) {
			rbody.MovePosition (rbody.position + movement_vector * (Time.deltaTime * 2f));
			anim.speed = 2.0f;
		} else {
			rbody.MovePosition (rbody.position + movement_vector * Time.deltaTime * 1.25f);
			anim.speed = 1.0f;

		}
			
		if (Input.GetKey (KeyCode.Z) || Input.GetKey (KeyCode.J)) {
			rbody.MovePosition (rbody.position + movement_vector * Time.deltaTime * 0f);
			anim.speed = 1.0f;
			anim.SetBool ("iswalking", false);
			anim.SetBool ("isHeavyattacking", true);
		} else {
			anim.SetBool ("isHeavyattacking", false);
		}
	}
}
	
