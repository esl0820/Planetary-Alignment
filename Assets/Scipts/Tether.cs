using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tether : MonoBehaviour {

	public Transform mercury = null;
	public Transform venus = null;
	public Transform earth = null;
	public Transform mars = null;
	public Transform saturn = null;
	public Transform tardis = null;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "Put the planets in the right order by matching them to the colored rings!";

		float distMercury = Vector3.Distance(tardis.position, mercury.position); 
		float distVenus = Vector3.Distance(tardis.position, venus.position); 
		float distEarth = Vector3.Distance(tardis.position, earth.position);
		float distMars = Vector3.Distance(tardis.position, mars.position);
		float distSaturn = Vector3.Distance(tardis.position, saturn.position); 

		if (distMercury < 100) {
			textBuffer += "\nPress [E] to move the planet away from the sun!";
			textBuffer += "\nPress [Q] to move the planet closer to the sun!";
			if (Input.GetKeyDown (KeyCode.E)) {
				mercury.Translate (Vector3.forward * 15000f * Time.deltaTime);
			}
			if (Input.GetKeyDown (KeyCode.Q)) {
				mercury.Translate (Vector3.forward * -15000f * Time.deltaTime);
			}
		}
		if (distVenus < 100) {
			textBuffer += "\nPress [E] to move the planet away from the sun!";
			textBuffer += "\nPress [Q] to move the planet closer to the sun!";
			if (Input.GetKeyDown (KeyCode.E)) {
				venus.Translate (Vector3.forward * 15000f * Time.deltaTime);
			}
			if (Input.GetKeyDown (KeyCode.Q)) {
				venus.Translate (Vector3.forward * -15000f * Time.deltaTime);
			}
		}
		if (distEarth < 100) {
			textBuffer += "\nPress [E] to move the planet away from the sun!";
			textBuffer += "\nPress [Q] to move the planet closer to the sun!";
			if (Input.GetKeyDown (KeyCode.E)) {
				earth.Translate (Vector3.forward * 15000f * Time.deltaTime);
			}
			if (Input.GetKeyDown (KeyCode.Q)) {
				earth.Translate (Vector3.forward * -15000f * Time.deltaTime);
			}
		}
		if (distMars < 100) {
			textBuffer += "\nPress [E] to move the planet away from the sun!";
			textBuffer += "\nPress [Q] to move the planet closer to the sun!";
			if (Input.GetKeyDown (KeyCode.E)) {
				mars.Translate (Vector3.forward * 15000f * Time.deltaTime);
			}
			if (Input.GetKeyDown (KeyCode.Q)) {
				mars.Translate (Vector3.forward * -15000f * Time.deltaTime);
			}
		}
		if (distSaturn < 200) {
			textBuffer += "\nPress [E] to move the planet away from the sun!";
			textBuffer += "\nPress [Q] to move the planet closer to the sun!";
			if (Input.GetKeyDown (KeyCode.E)) {
				saturn.Translate (Vector3.forward * 15000f * Time.deltaTime);
			}
			if (Input.GetKeyDown (KeyCode.Q)) {
				saturn.Translate (Vector3.forward * -15000f * Time.deltaTime);
			}
		}
		GetComponent<Text>().text = textBuffer;
	}
}
