using UnityEngine;
using System.Collections;

public class WallChecker : MonoBehaviour {

	void OnTriggerEnter (Collider other){ //when the wallChecker collider is triggered
			if (other.gameObject.tag == "Wall") { //if the other gameobject is a wall
				Debug.Log ("There's a wall!"); //send a message to the console saying there's a wall
				MoveCamera.noWallFront = false; //set noWallFront boolean in MoveCamera script to false
			}
		} 
	void OnTriggerExit (Collider other) { //when wallChecker exits the collider
		if (other.gameObject.tag == "Wall"){ //if the other gameobject is a wall
			Debug.Log ("Exiting Trigger"); //send a message to the console saying the object is exiting the trigger
			MoveCamera.noWallFront = true; //set noWallFront boolean in MoveCamera script to true
	}
}
}
