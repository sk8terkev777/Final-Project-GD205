using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mydestroy : MonoBehaviour {
	public AudioSource testSound;
	public AudioClip boomSound;
	GameObject Splatter;


	void Start () {

		Splatter = GameObject.Find ("Splatter");




	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.CompareTag("Cube")){
			this.gameObject.SetActive (false);
			testSound.PlayOneShot (boomSound, 0.7f);
			Debug.Log ("Collide");
			Splatter.GetComponent < bloodscreen> ().value -= .2f;

		}

	}

}


