using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public static LevelManager levelManager; 

	private int Coin = 0;
	private bool gameOver = false;
	public Text CoinText;


	// Use this for initialization
	void Awake () {

		if (levelManager == null) {
			levelManager = this;
		} else if (levelManager != this) {
			Destroy (gameObject);
		}
	}
	public void SetCoin(int x)
	{
		Coin = Coin + x;
		CoinText.text = Coin.ToString ();
		Debug.Log (Coin);
	
	}

	public int GetCoin()
	{
		return Coin;
    }
}

