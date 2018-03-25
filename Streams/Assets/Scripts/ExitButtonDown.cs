using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonDown : MonoBehaviour {


	void OnMouseUp() {
		Application.Quit ();
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.E))
			Application.Quit ();
	}
}
