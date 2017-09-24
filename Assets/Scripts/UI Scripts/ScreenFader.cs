using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour
{
	Animator anim;
	bool isFading = false;
	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
	}

	public IEnumerator FadeToClear ()
	{
		isFading = true;
		anim.SetTrigger ("FadeIn");

		while (isFading)
			yield return null;
	}

	public IEnumerator FadetoBlack ()
	{
		gameObject.transform.SetSiblingIndex (7);
		isFading = true;
		anim.SetTrigger ("FadeOut");

		while (isFading)
			yield return null;
	}

	void AnimationComplete ()
	{
		isFading = false;
		gameObject.transform.SetSiblingIndex (0);
	}
}
