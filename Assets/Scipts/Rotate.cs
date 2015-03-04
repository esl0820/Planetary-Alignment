using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	float rotation = 125f;
	public Transform tardis = null;
	public Transform center = null;
	bool tooFar = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKey (KeyCode.W) ) {
			transform.Rotate (Vector3.up, 1.5f * rotation * Time.deltaTime);
		} else {
			transform.Rotate (Vector3.up, -rotation * Time.deltaTime);
		}

		float distance = Vector3.Distance(tardis.position, center.position); 

		if (distance > 1) {
			tooFar = true;
		}
		if (tooFar) {
			transform.position = Vector3.MoveTowards(transform.position, center.position, 5f * Time.deltaTime);
		}

		//if (Input.GetKey (KeyCode.LeftArrow)) {
		//	transform.Rotate (Vector3.left, rotation * Time.deltaTime);
		//}
		//if (Input.GetKey (KeyCode.RightArrow)) {
		//	transform.Rotate (Vector3.right, rotation * Time.deltaTime);
		//}
		//if ( Input.GetKey (KeyCode.UpArrow) ) {
		//	transform.position += new Vector3( 0f, 10f, 0f) * Time.deltaTime;
		//}
		//down when pressing shift
		//if ( Input.GetKey (KeyCode.DownArrow) ) {
		//	transform.position += new Vector3( 0f, -10f, 0f) * Time.deltaTime;
		//}
	
	}
}
