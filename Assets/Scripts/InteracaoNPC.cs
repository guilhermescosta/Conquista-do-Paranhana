using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteracaoNPC : MonoBehaviour {
	private bool isTalk;
	public GameObject talkBalloon;
	public string[] phrases;
	public Text phrasesText;
	public int indexPhrase;
	public Text talkText;

	/*void Start() {
		indexPhrase = 0;
	}*/

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			isTalk = true;
			indexPhrase = 0;
		}
	}
	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			isTalk = false;
			indexPhrase = 0;
		}
	}

	void FixedUpdate(){
		if (isTalk && Input.GetKeyDown (KeyCode.E) && indexPhrase <= phrases.Length - 1) {
			phrasesText.text = phrases [indexPhrase];
			talkBalloon.GetComponent<Image> ().enabled = true;
			indexPhrase++;
		} else if (isTalk  && Input.GetKeyDown (KeyCode.E) && indexPhrase >= phrases.Length - 1){
			talkBalloon.GetComponent<Image> ().enabled = false;
			talkText = talkBalloon.GetComponentInChildren<Text> ();
			talkText.text = "";
		}
	}
}