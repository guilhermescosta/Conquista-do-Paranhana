using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sleep : MonoBehaviour {

	public bool toSleep;
	public Timer _newDay;

	//Heal
	public Image CurrentHealth;
	public Text RatioText;

	private float heatlh = 100;


	//fade

	void Start (){

		toSleep = false;
	}

	void FixedUpdate(){

		if (toSleep && Input.GetKeyDown (KeyCode.E)) {
			EndTurn ();
			UpdateHealthbar ();
		
		}
	}

	 void OnTriggerEnter2D (Collider2D other) {

		if (other.gameObject.tag == "Player") {
			Debug.Log ("cama");
			toSleep = true;
		}

	}
	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			toSleep = false;
		}
	}

	public void EndTurn(){
		_newDay.dia++;
		_newDay.horas = 5.00f;
		_newDay.minutos = 0f;
		_newDay.segundos = 0f;
	}

	//Heal
	private void UpdateHealthbar(){
		float ratio = heatlh; 
		//CurrentHealth.rectTransform.localScale = new Vector3 (ratio, 1, 1);
		RatioText.text = (  ratio ).ToString () + '%';
		Debug.Log ("curou! " + ratio);


	}

	//fade 







}
