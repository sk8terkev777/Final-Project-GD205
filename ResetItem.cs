using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetItem : MonoBehaviour {

	float EndTime;
	public float Duration;
	Vector3 StartingPosition;
	// Use this for initialization
	void Start () {
		EndTime = 0;
		StartingPosition = transform.position;

		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > EndTime && EndTime != 0) {
			transform.position = StartingPosition;
			EndTime = 0;
		}
			
			

		
	}

	void OnCollisionEnter(Collision Hit){
		if (Hit.collider.gameObject.name == "Terrain") {
			EndTime = Time.time + Duration;

		
		
		}
	
	
	
	
	}



			


}

