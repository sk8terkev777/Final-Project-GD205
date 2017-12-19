using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMent : MonoBehaviour {
	public GameObject Player;
	//public int movementAmt = 1;
	Vector3 startingPosition;
	public AudioSource testSound2;
	public AudioClip boomSound2;


	// Use this for initialization
	void Start () {
		startingPosition = Player.transform.position;


		
	}
	
	// Update is called once per frame
	void Update () {

	

	
	
	
	}






	    void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			//Destroy (this.gameObject);
			Player.transform.position = startingPosition;
			testSound2.PlayOneShot (boomSound2, 0.7f);
		}
	}














}



