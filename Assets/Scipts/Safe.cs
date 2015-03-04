using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Safe : MonoBehaviour {

	public Transform mercury = null;
	public Transform venus = null;
	public Transform earth = null;
	public Transform mars = null;
	public Transform saturn = null;
	public Transform sun = null;
	//public Transform mercuryPath = null;
	//public Transform venusPath = null;
	//public Transform earthPath = null;
	//public Transform marsPath = null;
	//public Transform saturnPath = null;

	bool mercurySafe = false;
	bool venusSafe = false;
	bool earthSafe = false;
	bool marsSafe = false;
	bool saturnSafe = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		string textBuffer = "Save the Planets!";

		float distMercury = Vector3.Distance (mercury.position , sun.position);
		float distVenus = Vector3.Distance (venus.position , sun.position);
		float distEarth = Vector3.Distance (earth.position , sun.position);
		float distMars = Vector3.Distance (mars.position , sun.position);
		float distSaturn = Vector3.Distance (saturn.position , sun.position);

		if (distMercury < 1250f && distMercury > 750f) {
			mercurySafe = true;
		}
		if (!mercurySafe) {
			textBuffer += "\nMercury is In Danger!";
		} else {
			textBuffer += "\nMercury is Safe!";
		}
		if (distVenus < 1750 && distVenus > 1250) {
			venusSafe = true;
		}
		if (!venusSafe) {
			textBuffer += "\nVenus is In Danger!";
		} else {
			textBuffer += "\nVenus is Safe!";
		}
		if (distEarth < 2250 && distEarth > 1750) {
			earthSafe = true;
		}
		if (!earthSafe) {
			textBuffer += "\nEarth is In Danger!";
		} else {
			textBuffer += "\nEarth is Safe!";
		}
		if (distMars < 2750 && distMars > 2250) {
			marsSafe = true;
		}
		if (!marsSafe) {
			textBuffer += "\nMars is In Danger!";
		} else {
			textBuffer += "\nMars is Safe!";
		}
		if (distSaturn < 3250 && distSaturn > 2750) {
			saturnSafe = true;
		}
		if (!saturnSafe) {
			textBuffer += "\nSaturn is In Danger!";
		} else {
			textBuffer += "\nSaturn is Safe!";
		}

		if (mercurySafe && venusSafe && earthSafe && marsSafe && saturnSafe) {
			textBuffer = "The Planets are safe!";
		}

		GetComponent<Text>().text = textBuffer;
	}

}
