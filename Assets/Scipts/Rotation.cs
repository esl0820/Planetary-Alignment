using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public float rotation = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (Vector3.up, rotation * Time.deltaTime);
	
	}
}

