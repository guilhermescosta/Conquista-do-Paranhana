using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoGold : MonoBehaviour {
	public bool isTake;
	public SpriteRenderer sr2;
	void Start () {
		sr2 = GetComponent<SpriteRenderer> ();
		sr2.color = new Color (1, 1, 1, 1);
	}
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			isTake = true;
		}
	}
	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			sr2.color = new Color (1, 1, 1, 1);
			isTake = false;
		}
	}

	void FixedUpdate(){
		if (isTake && Input.GetKeyDown (KeyCode.E)) {
			sr2.color = new Color (0, 0, 0, 0);
			Debug.Log ("50 de Gold adicionado");
			gameObject.SetActive (false);
			LevelManager.levelManager.SetCoin (50);
		}
	}
}