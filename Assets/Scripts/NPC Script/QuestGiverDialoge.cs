using UnityEngine;
using System.Collections;

public class QuestGiverDialoge : MonoBehaviour
{

	public string dialogue;
	private DialogueManager dMAn;
	public Transform warpTarget;
	public Transform mapTarget;
	public Transform warpTarget2;
	public Transform mapTarget2;
	public GameObject Player;
	public GameObject map;
	public GameObject map2;

	int random;
	// Use this for initialization
	void Start ()
	{
		dMAn = FindObjectOfType <DialogueManager> ();
	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnTriggerStay2D (Collider2D other)
	{

		if (other.gameObject.name == "Player") {
			dMAn.ShowBox (dialogue);
			dMAn.ShowIntruction ();
			random = Random.Range (0, 1);
			if (Input.GetKeyDown (KeyCode.Space) && random == 0) {
				var clone = Instantiate (map, mapTarget.transform.position, Quaternion.Euler (Vector3.zero));
				StartCoroutine (screenfader ());
			}
			if (Input.GetKeyDown (KeyCode.Space) && random == 1) {
				var clone = Instantiate (map2, mapTarget2.transform.position, Quaternion.Euler (Vector3.zero));
				StartCoroutine (screenfader2 ());
			}
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{

		if (other.gameObject.name == "Player") {
			dMAn.dBox.SetActive (false);
			dMAn.iText.SetActive (false);
			dMAn.dialogActive = false;
		}

	}

	public IEnumerator screenfader ()
	{
		dMAn.dBox.SetActive (false);
		dMAn.iText.SetActive (false);
		dMAn.dialogActive = false;
		ScreenFader sf = GameObject.FindGameObjectWithTag ("Fader").GetComponent<ScreenFader> ();
		yield return StartCoroutine (sf.FadetoBlack ());
		Player.transform.position = warpTarget.position;
		Camera.main.transform.position = warpTarget.position;
		yield return StartCoroutine (sf.FadeToClear ());
	}

	public IEnumerator screenfader2 ()
	{
		dMAn.dBox.SetActive (false);
		dMAn.iText.SetActive (false);
		dMAn.dialogActive = false;
		ScreenFader sf = GameObject.FindGameObjectWithTag ("Fader").GetComponent<ScreenFader> ();
		yield return StartCoroutine (sf.FadetoBlack ());
		Player.transform.position = warpTarget2.position;
		Camera.main.transform.position = warpTarget.position;
		yield return StartCoroutine (sf.FadeToClear ());
	}
}

