using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLimitScript : MonoBehaviour {

	void Awake(){
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 60;
		DontDestroyOnLoad (transform.gameObject);
		
	}
}
