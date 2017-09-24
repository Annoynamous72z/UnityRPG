using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{

	public GameObject endtext;

	public void endGame ()
	{
		endtext.SetActive (true);
	}

	public void returntomenu ()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
