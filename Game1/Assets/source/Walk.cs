using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {

	private float speed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		float horizontal = Input.GetAxis ("Horizontal");

		transform.Translate (new Vector3(horizontal * speed * Time.deltaTime,0));
	
	}
}
