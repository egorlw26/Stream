using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonDown : MonoBehaviour {

	void OnMouseUp() {
		SceneManager.LoadScene ("GameScene");
	}
}
