using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	//[SerializeField]
	private Wizard wizard;

	// Enumerator
	public enum GameState {
		Started,
		Paused,
		Ended,
		MainMenu,
		HighScoreMenu,
		SettingsMenu,
		PlayerDied,
		PlayerRespawn
	}

	// Arrays
	public GameObject[] items;  // Shows up in IDE

	public List<bool> things;

	public List<GameObject> stuff = new List<GameObject> ();

	GameState gameState = GameState.MainMenu;

	void Awake() { // MonoBehaviour 
		print("Game State: " + gameState);

		if(gameState == GameState.MainMenu) {
			print("We're in the main menu");
		}
	}


	// Use this for initialization
	void Start () // MonoBehaviour
	{

		// This method of using a string allows the ability to stop a coroutine
		StartCoroutine("PrintDelay"); // We'll have to set a class properties for default function parameters
		StopCoroutine("PrintDelay");
	

		// This method is going to execute no matter what
		StartCoroutine(PrintAfterDelay (1f));
//		Wizard.power = 99;
//		Debug.Log("This wizard power is " + Wizard.power);
//		Wizard.WizardInfo();

		//myBody = GetComponent<Rigidbody> ();
		//wizard.Attack ();
	}


	// Delegation
	void OnEnable() {  // MonoBehaviour
		Wizard.playerDied += ExecuteAfterEventCall; // Subscribe to Wizard Event
	}

	void OnDisable() { // MonoBehaviour
		Wizard.playerDied -= ExecuteAfterEventCall; // UnSubscribe to Wizard Event
	}

	void ExecuteAfterEventCall(int num1, int num2) {
		print("Printed after wizard died event called from tester object:");
		print("Number 1: " + num1);
		print("Number 2: " + num2);
	}

	// Coroutines
	void printSomething() {
		print("something");
	}

	// Co-routine
	IEnumerator PrintAfterDelay (float time) {
		yield return new WaitForSeconds(time); // Affected by Game time use WaitForRealtime for real-world time
		print("Printed after " + time + " second(s)");
	}

	IEnumerator PrintDelay () {
		yield return new WaitForSeconds(2f);
		print("Printed after 2 second(s)");
	}

}
