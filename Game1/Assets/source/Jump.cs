using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	private int jumps = 2;
	public float strengh = 100f;
	public Rigidbody2D character;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (jumps > 0) {
			if (Input.GetKeyDown (KeyCode.Space)) {

				character.AddForce (new Vector2 (0, strengh * Time.deltaTime), ForceMode2D.Impulse);
				jumps--;	
			}
		}
	}

	void OnCollisionEnter2D(Collision2D body) {
	
		if (body.gameObject.CompareTag ("GROUND")) {
			jumps = 2;
		}
	}

}
