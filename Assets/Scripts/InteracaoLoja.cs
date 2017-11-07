using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteracaoLoja : MonoBehaviour {

	private bool isShop;              // se o jogador estiver dentro do trigger da loja
	public GameObject shopPanel;
	public string[] itens;
	public Text	phrasesText;
	public int indexItem;
	public Text talkText;

	public bool isShopping;    // se o jogador estiver com a loja aberta
	public GameObject cursorLoja;
	public float cursorPosition;

	void Start(){
		isShopping = false;
		cursorPosition = 150;
	}


	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			isShop = true;
			indexItem = 0;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.tag == "Player") {
			isShop = false;
			indexItem = 0;
		}
	}

	void FixedUpdate (){
	
		if (isShop && Input.GetKeyDown (KeyCode.E) && isShopping==false  ) {		// && indexItem <= itens.Length - 1
			
			foreach (string index in itens) {
					phrasesText.text += index + "\n";
				}

			shopPanel.GetComponent<Image> ().enabled = true;
			isShopping = true;
			cursorLoja.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.UpArrow) && isShopping==true) {  

			if (indexItem <= 0) {
				indexItem = itens.Length - 1;
				cursorPosition = 10;
				cursorLoja.GetComponent<RectTransform> ().localPosition = new Vector3 (-150,cursorPosition-20,0);;
			} 
			else {
				indexItem--;
				cursorPosition += 30;
				cursorLoja.GetComponent<RectTransform> ().localPosition = new Vector3 (-150,cursorPosition,0);
			}
		}


		if (Input.GetKeyDown (KeyCode.DownArrow) && isShopping == true) {

			if (indexItem == itens.Length ) {
				indexItem=0;
				cursorPosition = 150;
				cursorLoja.GetComponent<RectTransform> ().localPosition = new Vector3 (-150, cursorPosition+20, 0);
			
			} else {
				indexItem++;
				cursorPosition -= 30;
				cursorLoja.GetComponent<RectTransform> ().localPosition = new Vector3 (-150, cursorPosition, 0);
				
			}
		}

		if (  Input.GetKeyDown (KeyCode.E) && indexItem >= itens.Length - 1) {
			shopPanel.GetComponent<Image> ().enabled = false;
			isShopping = false;
			cursorLoja.SetActive (false);
			talkText.text="";


		}
	}
}
