using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoGold : MonoBehaviour {
	public bool isTake;
	public bool vAction;
	public SpriteRenderer sr2;
	public Sprite sTronco;
	void Start () {
		sr2 = GetComponent<SpriteRenderer> ();
		vAction = true;
	}
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			isTake = true;
		}
	}
	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			isTake = false;
		}
	}

	void FixedUpdate(){
		if (isTake && Input.GetKeyDown (KeyCode.E)&& vAction) {
			sr2.sprite = sTronco;
			Debug.Log ("50 de Gold adicionado");
			LevelManager.levelManager.SetCoin (50);
			LevelManager.levelManager.SetSede (5);
			LevelManager.levelManager.SetFome (10);
			vAction = false;
		}
	}
}