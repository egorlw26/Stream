using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsClick : MonoBehaviour {

	void OnMouseDown(){
		transform.localScale *= 1.5f; 
		}

	void OnMouseUp() {
		transform.localScale /=1.5f;
	}
}
