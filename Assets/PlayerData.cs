using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {

	public string playerName;
	public string playerSurname;    // esse campo deve ser modificado caso o sobrenome indique uma habilidade do personagem
	public float playerMoney;


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
