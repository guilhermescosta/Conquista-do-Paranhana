using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitArvore : MonoBehaviour {

	public void machadoarvore(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}
}
