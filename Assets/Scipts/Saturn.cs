﻿using UnityEngine;
using System.Collections;

public class Saturn : MonoBehaviour {

	public Transform sun;
	public Transform planet;
	public float orbit = 23;


	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//transform.position = Vector3.MoveTowards(planet.position, sun.position, 5f * Time.deltaTime);
		transform.RotateAround (Vector3.zero, Vector3.up, orbit * Time.deltaTime);


	}
}

