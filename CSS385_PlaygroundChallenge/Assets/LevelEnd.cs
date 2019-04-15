using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour {

	public int nextLevel = 0;
	private bool hasP1;
	private bool hasP2;

	// Use this for initialization
	void Start () {
		hasP1 = false;
		hasP2 = false;
	}

	// Update is called once per frame
	void Update () {
		if (hasP1 && hasP2) {
			SceneManager.LoadScene ("Level" + nextLevel, LoadSceneMode.Single);
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name.Equals("Player1")){
			hasP1 = true;
		}
		if(other.name.Equals("Player2")){
			hasP2 = true;
		}

	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if(other.name.Equals("Player1")){
			hasP1 = false;
		}
		if(other.name.Equals("Player2")){
			hasP2 = false;
		}
	}
}
