using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //call on the SceneManagement namespace of code for use in script

public class GameLoading : MonoBehaviour {

	public void StartGame(){ //create a function for starting the game
			SceneManager.LoadScene ("Maze1"); //load the level scene
		}

	public void BackToTitle() { //create a function for going back to the main menu
		SceneManager.LoadScene ("Menu"); //load the menu scene
	}
}
