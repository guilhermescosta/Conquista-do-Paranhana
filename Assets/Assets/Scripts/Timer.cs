using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text Tempo;
	public float segundos, minutos, horas;
	public GameObject _fundo; 
	public GameObject _cor;

	// Use this for initialization
	void Start () {
		Tempo = GetComponent<Text>()as Text;

		//_fundo = GameObject.Find ("Fundo");
		//_cor = _fundo.GetComponent<Color> ();

	}
	
	// Update is called once per frame
	void Update () {
		segundos += Time.deltaTime;
		Tempo.text = horas.ToString("00") + ":" + minutos.ToString ("00") + ":" + segundos.ToString ("00");
		if (segundos >= 60) {
			minutos++;
			segundos = 0;
		} else if (minutos >= 60) {
			horas++;
			minutos = 0;
		} else if (horas >= 24) {
			horas = 0;
		}
		/*
		if (horas > 19 && horas < 6 ) {
			_cor.color = Color.black;
		}*/


	}
}