using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimento : MonoBehaviour {

	public int exit;
	public GameObject talkBalloon;
	public GameObject shopPanel;

	void Start(){
		DontDestroyOnLoad (this);
//		Debug.Log (exit);
		talkBalloon = GameObject.Find ("Balao");
		shopPanel = GameObject.Find ("Panel");

	}

	void FixedUpdate () {

		if (talkBalloon.GetComponent<Image>().enabled==false && shopPanel.GetComponent<Image>().enabled==false ) {

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
			}
		}
	}
}