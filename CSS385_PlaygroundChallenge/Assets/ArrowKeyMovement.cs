using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeyMovement : MonoBehaviour {

	private float force = 10.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.up * force);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.down * force);
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.left * force);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector3.right * force);
		}
	}
}

