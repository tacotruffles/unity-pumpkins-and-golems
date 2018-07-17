using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Player {

//	private float mana = 33f;

	// Default constructor
	public Wizard() {

	}	

	public Wizard(string name, float health) {
		this.PlayerName = name;
		this.Health = health;
	}

	public override void Attack() {
		Debug.Log("[Wizard] Attack: Throwing a Fireball");
	}

//	public void ReplensihMana(float mana) {
//		this.mana = mana;
//	}
	
} // class
