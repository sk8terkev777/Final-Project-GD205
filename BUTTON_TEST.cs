using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUTTON_TEST : MonoBehaviour {


	
	// Update is called once per frame
	public void ChangeToScene (string sceneToChangeTo) {
		Application.LoadLevel (sceneToChangeTo);
	}
		
	}
