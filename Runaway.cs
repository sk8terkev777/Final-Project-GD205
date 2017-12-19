using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runaway : MonoBehaviour {

	public Transform target;
	Rigidbody avoid;
	public float thrust;


	// Use this for initialization
	void Start () {
		avoid = GetComponent<Rigidbody> ();
	}
		
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 targetDir = Vector3.Normalize (transform.position - target.position);
		avoid.AddForce (targetDir * thrust);
		
	}
}
