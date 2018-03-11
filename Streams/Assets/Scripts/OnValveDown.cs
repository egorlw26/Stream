using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnValveDown : MonoBehaviour {

	public Animator anima;

	void Start () 
	{
		anima = gameObject.GetComponent<Animator> ();
	}
	

	void Update () 
	{
		if (Input.GetKey (KeyCode.E)) 
		{
			anima.Play ("ValveRoll");
		}
	}
}
