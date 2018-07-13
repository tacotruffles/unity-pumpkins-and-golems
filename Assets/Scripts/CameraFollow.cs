using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform pumpkinPos;

	private float zDistance = 7f;
	private float yDistance = 4f;

	void Awake () {
		// Get the Pumpkin Position
		pumpkinPos = GameObject.Find ("Pumpkin").transform;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		temp.y = pumpkinPos.position.y + yDistance;
		temp.z = pumpkinPos.position.z - zDistance;

		transform.position = temp;
	}

	void FixedUpdate() {

	}
} // end class - CameraFollow
