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
		// If we fall off the front of the floor. Stop the game
		if(transform.position.y < -10) {
			Time.timeScale = 0f;
		}
	}

	// Called every several frames
	void FixedUpdate() {
		// Keep moving the pumpkin with arrow keys
		MovePumpkin ();	
	}

	// Pumpkin motion
	void MovePumpkin () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		myBody.AddForce (new Vector3(h * moveForce, 0f, v * moveForce));
	}

	// If we hit a Golem or Go Through the Pearly Gates...Game Over!
	void OnTriggerEnter(Collider target) {
		if(target.tag == "Golem" || target.tag == "Gate") {
			Time.timeScale = 0f;
		}
	}
} // class Pumpkin
