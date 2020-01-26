using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public float moveSpaces = 1.7f; //create a var for how much the player is moved (public so we can edit it in the inspector)
	float Rotate; //create a var for how much the player rotates

	//create a set of bool vars to detect where the player is facing
	public static bool facingLeft;
	public static bool facingForward;
	public static bool facingRight;
	public static bool facingBehind;

	public AudioClip bumpSound; //create a slot in the inspector for the sound of bumping into a wall
	public AudioClip footstep; //create a slot in the inspector for the sound clip of footsteps

	public static bool noWallFront; //create a bool var accesible by all scripts for checking if there is a wall in front of the player

	// Use this for initialization
	void Start () {
		//set all variables so that if the game is reset they also reset
		Rotate = 0f;
		facingLeft = false;
		facingForward = true;
		facingRight = false;
		facingBehind = false;
		noWallFront = true;
		Debug.Log ("Starting the game"); //send a message to the console indicating all variables are set
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) { //if the W key is pressed
			if (noWallFront == true) { //if there is no wall in front of the player
				AudioSource audio = GetComponent<AudioSource>(); //get AudioSource component
				audio.volume = 0.1f; //place the AudioSource volume at 0.1f
				audio.PlayOneShot (footstep); //play the footstep soundclip
				if (facingForward == true) { //if the player is facing forward
					float move = transform.position.z + moveSpaces;
					transform.position = new Vector3 (transform.position.x, transform.position.y, move); //the player moves along the z axis in the direction it's facing
				} else if (facingRight == true) { //if the player is facing right
					float move = transform.position.x + moveSpaces;
					transform.position = new Vector3 (move, transform.position.y, transform.position.z); //the player moves along the x axis in the direction it's facing
				} else if (facingBehind == true) { //if the player is facing behind
					float move = transform.position.z - moveSpaces;
					transform.position = new Vector3 (transform.position.x, transform.position.y, move); //the player moves along the z axis in the direction it's facing
				} else if (facingLeft == true) { //if the player is facing left
					float move = transform.position.x - moveSpaces;
					transform.position = new Vector3 (move, transform.position.y, transform.position.z); //the player moves along the x axis in the direction it's facing
				}
			} else if (noWallFront == false) { //if there is a wall in front of the player
				AudioSource audio = GetComponent<AudioSource>(); //get AudioSource component
				audio.volume = 0.4f; //place the AudioSource volume at 0.4f
				audio.PlayOneShot (bumpSound); //play the bumpSound soundclip
			}
		}

		if (Input.GetKeyDown (KeyCode.D)) { //if the D key is pressed
			Rotate = Rotate + 90f; //rotate variable increases by 90 degrees
			transform.rotation = Quaternion.Euler (0, Rotate, 0); //the player rotates to the right
			if (facingForward == true) { //if the player was facing forward
				facingRight = true; //set facingRight to true
				facingForward = false; //set facingForward to false
				Debug.Log ("I'm facing right"); //tell the console the player is now facing right
			} else if (facingRight == true) { //if the player was facing right
				facingBehind = true; //set facingBehind to true
				facingRight = false; //set facingRight to false
				Debug.Log ("I'm facing behind"); //tell the console the player is now facing behind
			} else if (facingBehind == true) { //if the player was facing behind
				facingLeft = true; //set facingLeft to true
				facingBehind = false; //set facingBehind to false
				Debug.Log ("I'm facing left"); //tell the console the player is now facing left
			} else if (facingLeft == true) { //if the player was facing left
				facingForward = true; //set facingForward to true
				facingLeft = false; //set facingLeft to false
				Debug.Log ("I'm facing forward"); //tell the console the player is facing forward
			}
		}
		
		if (Input.GetKeyDown (KeyCode.A)) { //if the A key is pressed
			Rotate = Rotate - 90f; //rotate variable decreases by 90 degrees
			transform.rotation = Quaternion.Euler (0, Rotate, 0); //player rotates to the left
			if (facingForward == true) { //if the player was facing forward
				facingLeft = true; //set facingLeft to true
				facingForward = false; //set facingForward to false
				Debug.Log ("I'm facing left"); //tell the console the player is now facing left
			} else if (facingRight == true) {  //if the player was facing right
				facingForward = true; //set facingForward to true
				facingRight = false; //set facingRight to false
				Debug.Log ("I'm facing forward"); //tell the console the player is facing forward
			} else if (facingBehind == true) {  //if the player was facing behind
				facingRight = true; //set facingRight to true
				facingBehind = false; //set facingBehind to false
				Debug.Log ("I'm facing right"); //tell the console the player is now facing right
			} else if (facingLeft == true) { //if the player was facing left
				facingBehind = true; //set facingBehind to true
				facingLeft = false; //set facingLeft to false
				Debug.Log ("I'm facing behind"); //tell the console the player is now facing behind
			}
		}
}
}
