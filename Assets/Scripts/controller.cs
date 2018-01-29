using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	static public inventario _inventarioController;
	public GameObject inventario;
	static public bool showinv = false;
	GameObject[] menus;


	// Use this for initialization
	void Start () {
//		_inventarioController = inventario.GetComponent<inventario> ();
		menus = GameObject.FindGameObjectsWithTag("menu");
		desabilitaINV();
	}
	void desabilitaINV(){
		GameObject thePlayer = GameObject.Find("Player");
		Movimento playerScript = thePlayer.GetComponent<Movimento>();
		for(int i=0; i< menus.Length; i++)
		menus[i].SetActive(showinv);
	}
	// Update is called once per frame
	void Update () {
		GameObject thePlayer = GameObject.Find("Player");
		Movimento playerScript = thePlayer.GetComponent<Movimento>();
		if (Input.GetKeyDown (KeyCode.I)) {
			showinv = !showinv;
			desabilitaINV ();
			if (playerScript.isMove) {
				playerScript.isMove = false;
			} else {
				playerScript.isMove = true;
			}
		} 
		
	}
}
