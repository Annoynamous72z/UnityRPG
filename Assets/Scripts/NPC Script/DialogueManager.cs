using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
	public GameObject dBox;
	public Text dText;
	public GameObject iText;
	public bool dialogActive;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	public void ShowBox (string dialogue)
	{
		dBox.SetActive (true);
		dText.text = dialogue;
	}

	public void ShowIntruction ()
	{
		iText.SetActive (true);
	}
}
 