using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimento : MonoBehaviour {

	public int exit;
	public GameObject talkBalloon;
	public GameObject shopPanel;
	public GameObject painelFade;

	public bool isMove;

	public Animator myAnimator;
	public SpriteRenderer mySprite;
	bool isFlip;



	void Start(){
		DontDestroyOnLoad (this);

		myAnimator = GetComponent<Animator> ();
		mySprite = GetComponent<SpriteRenderer> ();

//		Debug.Log (exit);
		talkBalloon = GameObject.Find ("Balao");
		shopPanel = GameObject.Find ("Panel");

		Debug.Log (talkBalloon.GetComponent<Image>().enabled);
		Debug.Log (shopPanel.GetComponent<Image>().enabled);
		Debug.Log (painelFade.GetComponent<Image>().enabled);

		if (talkBalloon.GetComponent<Image> ().enabled == false && shopPanel.GetComponent<Image> ().enabled == false && painelFade.GetComponent<Image> ().enabled == false) {
			isMove = true;
		} else {
			isMove = false;
		}
	}

	void FixedUpdate () {
		


		if (isMove) {
			Move ();
		}
	}

	void Move(){
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, -.1f, 0);
			myAnimator.SetBool ("walkDown", true);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, .1f, 0);
			myAnimator.SetBool ("walkUp", true);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (!isFlip) {
				mySprite.flipX = true;
				isFlip = true;
			}
			transform.Translate (-.1f, 0, 0);
			myAnimator.SetBool ("walkRight", true);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			if (isFlip) {
				mySprite.flipX = false;
				isFlip = false;
			}
			transform.Translate (.1f, 0, 0);
			myAnimator.SetBool ("walkRight", true);
		}

		//////
		if (Input.GetKeyUp (KeyCode.UpArrow)) { 
			myAnimator.SetBool ("walkUp", false);
		}
		if (Input.GetKeyUp (KeyCode.DownArrow)) { 
			myAnimator.SetBool ("walkDown", false);
		}
		if (Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyUp (KeyCode.LeftArrow)) { 
			myAnimator.SetBool ("walkRight", false);
		}
			
	}

}		
