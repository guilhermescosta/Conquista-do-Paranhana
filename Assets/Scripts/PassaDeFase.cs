using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassaDeFase : MonoBehaviour {

	public Movimento _mov;
	public GameObject _player;
	public GameObject playerStart;   // posicao de saida

	// Use this for initialization
	void Start () {
		_player = GameObject.Find ("Player");
		_mov= _player.GetComponent<Movimento> ();

		if (_mov.exit==1){
			_player.transform.position = new Vector3 (-4, 0, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log (other.name);
		if (other.gameObject.CompareTag("Player"))
		{
			_mov.exit = 1;
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);

		}
	}
}
