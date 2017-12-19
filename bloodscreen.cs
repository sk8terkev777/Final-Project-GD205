using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodscreen : MonoBehaviour {
	public Color colorStart = Color.red;
	public Color ColorEnd = Color.green;
	public float value = 1.0f;
	public Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		rend.material.color = Color.Lerp (colorStart, ColorEnd, value);
		
	}
}
