using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private float health = 0f;
	private string playerName = "";
	private float power = 10;

	// Constructor Default
	public Player () {
		
	}

	// Constructor
	public Player(string name, float health) {
		this.name = name;
		this.health = health;
	}

	// Setters / Getters
	public string PlayerName {
		get {
			return this.playerName;
		}
		set {
			this.playerName = value;
		}
	}

	public float Health {
		get {
			return this.health;
		}
		set {
			this.health = value;
		}
	}

	// Setters / Getters
	public float Power {
		get {
			return this.power;
		}
		set {
			this.power = value;
		}
	}

	public void PlayerInfo() {
		Debug.Log(name + " has health: " + health);
	}

	public virtual void Attack() {
		Debug.Log("[PLAYER] Attack: Enemy is Frozen");
	}

} // class