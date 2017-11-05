using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimento : MonoBehaviour {

	public int exit;

	void Start(){
		DontDestroyOnLoad (this);
		Debug.Log (exit);
	}

	void FixedUpdate () {

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, -.1f, 0);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, .1f, 0);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-.1f, 0, 0);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (.1f, 0, 0);
			//SceneManager.LoadScene ();
		}
	}
}