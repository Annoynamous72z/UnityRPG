using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dialogueholder : MonoBehaviour
{
	public string dialogue;
	private DialogueManager dMAn;
	PlayerStats player;
	private Endgame eg;

	void Start ()
	{
		dMAn = FindObjectOfType <DialogueManager> ();
		player = FindObjectOfType <PlayerStats> ();
		eg = FindObjectOfType <Endgame> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			dMAn.ShowBox (dialogue);
			Debug.Log (player.currentLevel);
			if (player.currentLevel == 99) {
				eg.endGame ();
			}
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			dMAn.dBox.SetActive (false);
			dMAn.dialogActive = false;
		}
	}
}
