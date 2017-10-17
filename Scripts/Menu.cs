using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour {

	public string newGame;
	public string loadGame;
	public string options;
	public string exitGame;

	public void NewGame(){
	
		//SceneManager.LoadScene (newGame);
		Debug.Log("NewGamebtn");
	}

	public void LoadGame(){

		//SceneManager.LoadScene (loadGame);
		Debug.Log("LoadGamebtn");

	}

	public void Options(){

		//SceneManager.LoadScene (options);
		Debug.Log("Optionbtn");
	}

	public void ExitGame(){

		//SceneManager.LoadScene (exitGame);
		Debug.Log("ExitGamebtn");
	}


}
