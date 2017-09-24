using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
	// Use this for initialization


	public void StartLevel ()
	{
		SceneManager.LoadScene ("MainWorldMap");
	}
	// Update is called once per frame

	public void ExitGame ()
	{
		Application.Quit ();
	}

	void Update ()
	{
	
	}
}
