using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text Tempo;
	public Text Data;
	public SpriteRenderer Fundo_invisivel;
	public float segundos, minutos, horas, dias, meses, anos;
	public Color startColor;
	public Color endColor;


	// Use this for initialization
	void Start () {
		
		

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
			dias++;

		} 

		if (horas <= 19 || horas >= 6 ) {
			//GetComponent<SpriteRenderer> ().color = Color.Lerp (startColor, endColor, t);

			float t = 1.0f;
			Fundo_invisivel.color = Color.Lerp ( endColor, startColor, t);
		}if (horas >= 19 || horas <= 6) {
			float t = 1.0f;
			Fundo_invisivel.color = Color.Lerp (startColor, endColor, t);
		
		}

		Data.text = dias.ToString("00") + "/" + meses.ToString("00") + "/" + anos.ToString("00");
		if (dias >= 31) {
			meses++;
		}



	}
}