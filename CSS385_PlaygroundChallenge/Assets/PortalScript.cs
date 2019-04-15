using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour {

	public bool portalOpen = false;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		GameObject destination = GameObject.Find (this.name + "-Dest");
		if (portalOpen) {
			other.transform.position = destination.transform.position;
		}
	}
}
