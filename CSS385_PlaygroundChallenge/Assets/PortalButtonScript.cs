using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		GameObject portal = GameObject.Find (this.name.Replace("-Button",""));
		PortalScript ps = portal.GetComponent<PortalScript> ();
		ps.portalOpen = true;
		portal.GetComponent<SpriteRenderer>().color = new Color (0, 100, 0);
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		GameObject portal = GameObject.Find (this.name.Replace("-Button",""));
		PortalScript ps = portal.GetComponent<PortalScript> ();
		ps.portalOpen = false;
		portal.GetComponent<SpriteRenderer>().color = new Color (100, 0, 0);
	}
}
