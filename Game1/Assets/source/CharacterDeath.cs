﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDeath : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {

		print ("Colide");

		GameObject gameObject = collider.gameObject;

		if (gameObject.CompareTag ("Player")) {
			
			Destroy (gameObject);
			GameObject.Instantiate( player, new Vector3 (-17f, -2.18f, 0), player.transform.rotation );

		}

	}
}
