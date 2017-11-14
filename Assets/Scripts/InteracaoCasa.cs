using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteracaoCasa : MonoBehaviour {

	private bool isHome;
	public SpriteRenderer _home;

	void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.tag == "Player" && isHome == false) {
		
			isHome = true;
		
		} else { 
			isHome = false;
		}
	
	}


	void FixedUpdate (){
	
		if (isHome) {

			_home.color = Color.black;

		} else {
		
			_home.color = Color.white ;
		}
	
	
	}


}
