using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoNPC : MonoBehaviour {
	private bool isTalk;
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			isTalk = true;
		}
	}
	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			isTalk = false;
		}
	}

	void FixedUpdate(){
		if (isTalk && Input.GetKeyDown (KeyCode.E))
			Debug.Log ("Oi eu sou o Goku");
	}
}
