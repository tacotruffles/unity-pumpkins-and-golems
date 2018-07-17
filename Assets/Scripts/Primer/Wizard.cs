using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Player {

	public static int power = 100;

	// Delegate
	public delegate void PlayerDied(int a, int b);
	public static event PlayerDied playerDied;


	void Start() {  // Inherited from Player
		if(playerDied != null) {
			playerDied(69, 31);
		}
	}

	// Default constructor
	public Wizard() {
		
	}	

	public Wizard(string name, float health) {
		this.PlayerName = name;
		this.Health = health;
	}

	public static void WizardInfo() {
		Debug.Log("This is called from Wizard Class");
	}

	public override void Attack() {
		Debug.Log("[Wizard] Attack: Throwing a Fireball");
	}

//	public void ReplensihMana(float mana) {
//		this.mana = mana;
//	}
	
} // class
