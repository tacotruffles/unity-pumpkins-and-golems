using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	[SerializeField]
	private Wizard wizard;

	private Rigidbody myBody;



	// Use this for initialization
	void Start ()
	{
		myBody = GetComponent<Rigidbody> ();
		wizard.Attack ();
	}

}
