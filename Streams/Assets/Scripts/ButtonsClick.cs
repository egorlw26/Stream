using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsClick : MonoBehaviour {

	void OnMouseDown(){
		transform.localScale = new Vector3 (4.5f, 4.5f, 4.5f);
	}

	void OnMouseUp() {
		transform.localScale = new Vector3 (4f, 4f, 4f);
	}
}
