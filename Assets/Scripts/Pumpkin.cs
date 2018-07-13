using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour {

	public float moveForce = 10f;

	private Rigidbody myBody;


	void Awake() {
		myBody = GetComponent<Rigidbody> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Called every several frames
	void FixedUpdate() {
		MovePumpkin ();	
	}


	void MovePumpkin () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		myBody.AddForce (new Vector3(h * moveForce, 0f, v * moveForce));
	}
} // class Pumpkin
