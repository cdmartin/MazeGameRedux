using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //call on the SceneManagement namespace of code for use in script

public class MapScreen : MonoBehaviour {
	//create a slot in the inspector for the map gameobject and all of the square sprites that represent rooms
	public GameObject Map;
	public GameObject A5;
	public GameObject A6;
	public GameObject A7;
	public GameObject A8;
	public GameObject A9;
	public GameObject A10;
	public GameObject A11;
	public GameObject A12;
	public GameObject A13;
	public GameObject A14;
	public GameObject B7;
	public GameObject B14;
	public GameObject C7;
	public GameObject C8;
	public GameObject C9;
	public GameObject C13;
	public GameObject C14;
	public GameObject D4;
	public GameObject D5;
	public GameObject D6;
	public GameObject D13;
	public GameObject E4;
	public GameObject E6;
	public GameObject E7;
	public GameObject E8;
	public GameObject E9;
	public GameObject E10;
	public GameObject E11;
	public GameObject E13;
	public GameObject E14;
	public GameObject F4;
	public GameObject F11;
	public GameObject F12;
	public GameObject F14;
	public GameObject G1;
	public GameObject G2;
	public GameObject G3;
	public GameObject G4;
	public GameObject G8;
	public GameObject G12;
	public GameObject G13;
	public GameObject G14;
	public GameObject H1;
	public GameObject H4;
	public GameObject H8;
	public GameObject H9;
	public GameObject H10;
	public GameObject H11;
	public GameObject H14;
	public GameObject I1;
	public GameObject I4;
	public GameObject I6;
	public GameObject I8;
	public GameObject I11;
	public GameObject I14;
	public GameObject J1;
	public GameObject J4;
	public GameObject J6;
	public GameObject J8;
	public GameObject J10;
	public GameObject J11;
	public GameObject J14;
	public GameObject K1;
	public GameObject K4;
	public GameObject K6;
	public GameObject K10;
	public GameObject K14;
	public GameObject L1;
	public GameObject L4;
	public GameObject L5;
	public GameObject L6;
	public GameObject L10;
	public GameObject L11;
	public GameObject L12;
	public GameObject L13;
	public GameObject L14;
	public GameObject KeySquare;
	public GameObject EndSquare;

	public GameObject KeyIcon; //create a slot in the inspector for the key icon

    public GameObject batteryPickup;
    public bool BatteryAlive;

	public AudioClip keyNotice; //create a slot in the inspector for the key soundclip
	public AudioClip doorOpen; //create a slot in the inspector for the door soundclip

	public static int KeyGet = 0; //set a var accesible by all scripts for whether or not the player has the key
	public GameObject door; //create a slot in the inpector for the door gameObject

	//create a set of bools determining if the player has visited these rooms with the flashlight on
	bool A5square;
	bool A6square;
	bool A7square;
	bool A8square;
	bool A9square;
	bool A10square;
	bool A11square;
	bool A12square;
	bool A13square;
	bool A14square;
	bool B7square;
	bool B14square;
	bool C7square;
	bool C8square;
	bool C9square;
	bool C13square;
	bool C14square;
	bool D4square;
	bool D5square;
	bool D6square;
	bool D13square;
	bool E4square;
	bool E6square;
	bool E7square;
	bool E8square;
	bool E9square;
	bool E10square;
	bool E11square;
	bool E13square;
	bool E14square;
	bool F4square;
	bool F11square;
	bool F12square;
	bool F14square;
	bool G1square;
	bool G2square;
	bool G3square;
	bool G4square;
	bool G8square;
	bool G12square;
	bool G13square;
	bool G14square;
	bool H1square;
	bool H4square;
	bool H8square;
	bool H9square;
	bool H10square;
	bool H11square;
	bool H14square;
	bool I1square;
	bool I4square;
	bool I6square;
	bool I8square;
	bool I11square;
	bool I14square;
	bool J1square;
	bool J4square;
	bool J6square;
	bool J8square;
	bool J10square;
	bool J11square;
	bool J14square;
	bool K1square;
	bool K4square;
	bool K6square;
	bool K10square;
	bool K14square;
	bool L1square;
	bool L4square;
	bool L5square;
	bool L6square;
	bool L10square;
	bool L11square;
	bool L12square;
	bool L13square;
	bool L14square;
	bool Keysquare;
	bool Endsquare;


	// Use this for initialization
	void Start () {
		//set all map and other UI objects inactive
		Map.SetActive (false);
		A5.SetActive (false);
		A6.SetActive (false);
		A7.SetActive (false);
		A8.SetActive (false);
		A9.SetActive (false);
		A10.SetActive (false);
		A11.SetActive (false);
		A12.SetActive (false);
		A13.SetActive (false);
		A14.SetActive (false);
		B7.SetActive (false);
		B14.SetActive (false);
		C7.SetActive (false);
		C8.SetActive (false);
		C9.SetActive (false);
		C13.SetActive (false);
		C14.SetActive (false);
		D4.SetActive (false);
		D5.SetActive (false);
		D6.SetActive (false);
		D13.SetActive (false);
		E4.SetActive (false);
		E6.SetActive (false);
		E7.SetActive (false);
		E8.SetActive (false);
		E9.SetActive (false);
		E10.SetActive (false);
		E11.SetActive (false);
		E13.SetActive (false);
		E14.SetActive (false);
		F4.SetActive (false);
		F11.SetActive (false);
		F12.SetActive (false);
		F14.SetActive (false);
		G1.SetActive (false);
		G2.SetActive (false);
		G3.SetActive (false);
		G4.SetActive (false);
		G8.SetActive (false);
		G12.SetActive (false);
		G13.SetActive (false);
		G14.SetActive (false);
		H1.SetActive (false);
		H4.SetActive (false);
		H8.SetActive (false);
		H9.SetActive (false);
		H10.SetActive (false);
		H11.SetActive (false);
		H14.SetActive (false);
		I1.SetActive (false);
		I4.SetActive (false);
		I6.SetActive (false);
		I8.SetActive (false);
		I11.SetActive (false);
		I14.SetActive (false);
		J1.SetActive (false);
		J4.SetActive (false);
		J6.SetActive (false);
		J8.SetActive (false);
		J10.SetActive (false);
		J11.SetActive (false);
		J14.SetActive (false);
		K1.SetActive (false);
		K4.SetActive (false);
		K6.SetActive (false);
		K10.SetActive (false);
		K14.SetActive (false);
		L1.SetActive (false);
		L4.SetActive (false);
		L5.SetActive (false);
		L6.SetActive (false);
		L10.SetActive (false);
		L11.SetActive (false);
		L12.SetActive (false);
		L13.SetActive (false);
		L14.SetActive (false);
		EndSquare.SetActive (false);
		KeySquare.SetActive (false);
		KeyIcon.SetActive (false);

		//set all bool variables false - the player has not visited these rooms with the flashlight on yet
		bool A5square = false;
		bool A6square = false;
		bool A7square = false;
		bool A8square = false;
		bool A9square = false;
		bool A10square = false;
		bool A11square = false;
		bool A12square = false;
		bool A13square = false;
		bool A14square = false;
		bool B7square = false;
		bool B14square = false;
		bool C7square = false;
		bool C8square = false;
		bool C9square = false;
		bool C13square = false;
		bool C14square = false;
		bool D4square = false;
		bool D5square = false;
		bool D6square = false;
		bool D13square = false;
		bool E4square = false;
		bool E6square = false;
		bool E7square = false;
		bool E8square = false;
		bool E9square = false;
		bool E10square = false;
		bool E11square = false;
		bool E13square = false;
		bool E14square = false;
		bool F4square = false;
		bool F11square = false;
		bool F12square = false;
		bool F14square = false;
		bool G1square = false;
		bool G2square = false;
		bool G3square = false;
		bool G4square = false;
		bool G8square = false;
		bool G12square = false;
		bool G13square = false;
		bool G14square = false;
		bool H1square = false;
		bool H4square = false;
		bool H8square = false;
		bool H9square = false;
		bool H10square = false;
		bool H11square = false;
		bool H14square = false;
		bool I1square = false;
		bool I4square = false;
		bool I6square = false;
		bool I8square = false;
		bool I11square = false;
		bool I14square = false;
		bool J1square = false;
		bool J4square = false;
		bool J6square = false;
		bool J8square = false;
		bool J10square = false;
		bool J11square = false;
		bool J14square = false;
		bool K1square = false;
		bool K4square = false;
		bool K6square = false;
		bool K10square = false;
		bool K14square = false;
		bool L1square = false;
		bool L4square = false;
		bool L5square = false;
		bool L6square = false;
		bool L10square = false;
		bool L11square = false;
		bool L12square = false;
		bool L13square = false;
		bool L14square = false;
		bool Keysquare = false;
		bool Endsquare = false;

        BatteryAlive = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.M)) { //if the M key is pressed
			if (!Map.activeInHierarchy) { //and the map is not active in the hierarchy
				Invoke ("PauseGame", 0); //invoke the pauseGame function immediately
			}
			if (Map.activeInHierarchy) { //if the map is active in the hierarchy when M is pressed
				Invoke ("Continue", 0); //invoke Continue function immediately
			}
		}
	}

	void PauseGame() { //create a function for pausing the game
		Time.timeScale = 0; //set timeScale to 0
		//set scripts that control player movement and flashlight inactive so player cannot play while paused
		GetComponent<MoveCamera>().enabled = false;  
		GetComponent<FlashLight>().enabled = false;
		Map.SetActive (true); //set the map active
		Debug.Log ("Game Paused"); //send a message to the console saying the game is paused
		//write a series of if functions that determine which squares on the map should be set active/shown based on the value of the bool vars
		if (A5square == true) {
			A5.SetActive (true);
		}
		if (A6square == true) {
			A6.SetActive (true);
		}
		if (A7square == true) {
			A7.SetActive (true);
		}
		if (A8square == true) {
			A8.SetActive (true);
		}
		if (A9square == true) {
			A9.SetActive (true);
		}
		if (A10square == true) {
			A10.SetActive (true);
		}
		if (A11square == true) {
			A11.SetActive (true);
		}
		if (A12square == true) {
			A12.SetActive (true);
		}
		if (A13square == true) {
			A13.SetActive (true);
		}
		if (A14square == true) {
			A14.SetActive (true);
		}
		if (B7square == true) {
			B7.SetActive (true);
		}
		if (B14square == true) {
			B14.SetActive (true);
		}
		if (C7square == true) {
			C7.SetActive (true);
		}
		if (C8square == true) {
			C8.SetActive (true);
		}
		if (C9square == true) {
			C9.SetActive (true);
		}
		if (C13square == true) {
			C13.SetActive (true);
		}
		if (C14square == true) {
			C14.SetActive (true);
		}
		if (D4square == true) {
			D4.SetActive (true);
		}
		if (D5square == true) {
			D5.SetActive (true);
		}
		if (D6square == true) {
			D6.SetActive (true);
		}
		if (D13square == true) {
			D13.SetActive (true);
		}
		if (E4square == true) {
			E4.SetActive (true);
		}
		if (E6square == true) {
			E6.SetActive (true);
		}
		if (E7square == true) {
			E7.SetActive (true);
		}
		if (E8square == true) {
			E8.SetActive (true);
		}
		if (E9square == true) {
			E9.SetActive (true);
		}
		if (E10square == true) {
			E10.SetActive (true);
		}
		if (E11square == true) {
			E11.SetActive (true);
		}
		if (E13square == true) {
			E13.SetActive (true);
		}
		if (E14square == true) {
			E14.SetActive (true);
		}
		if (F4square == true) {
			F4.SetActive (true);
		}
		if (F11square == true) {
			F11.SetActive (true);
		}
		if (F12square == true) {
			F12.SetActive (true);
		}
		if (F14square == true) {
			F14.SetActive (true);
		}
		if (G1square == true) {
			G1.SetActive (true);
		}
		if (G2square == true) {
			G2.SetActive (true);
		}
		if (G3square == true) {
			G3.SetActive (true);
		}
		if (G4square == true) {
			G4.SetActive (true);
		}
		if (G8square == true) {
			G8.SetActive (true);
		}
		if (G12square == true) {
			G12.SetActive (true);
		}
		if (G13square == true) {
			G13.SetActive (true);
		}
		if (G14square == true) {
			G14.SetActive (true);
		}
		if (H1square == true) {
			H1.SetActive (true);
		}
		if (H4square == true) {
			H4.SetActive (true);
		}
		if (H8square == true) {
			H8.SetActive (true);
		}
		if (H9square == true) {
			H9.SetActive (true);
		}
		if (H10square == true) {
			H10.SetActive (true);
		}
		if (H11square == true) {
			H11.SetActive (true);
		}
		if (H14square == true) {
			H14.SetActive (true);
		}
		if (I1square == true) {
			I1.SetActive (true);
		}
		if (I4square == true) {
			I4.SetActive (true);
		}
		if (I6square == true) {
			I6.SetActive (true);
		}
		if (I8square == true) {
			I8.SetActive (true);
		}
		if (I11square == true) {
			I11.SetActive (true);
		}
		if (I14square == true) {
			I14.SetActive (true);
		}
		if (J1square == true) {
			J1.SetActive (true);
		}
		if (J4square == true) {
			J4.SetActive (true);
		}
		if (J6square == true) {
			J6.SetActive (true);
		}
		if (J8square == true) {
			J8.SetActive (true);
		}
		if (J10square == true) {
			J10.SetActive (true);
		}
		if (J11square == true) {
			J11.SetActive (true);
		}
		if (J14square == true) {
			J14.SetActive (true);
		}
		if (K1square == true) {
			K1.SetActive (true);
		}
		if (K4square == true) {
			K4.SetActive (true);
		}
		if (K6square == true) {
			K6.SetActive (true);
		}
		if (K10square == true) {
			K10.SetActive (true);
		}
		if (K14square == true) {
			K14.SetActive (true);
		}
		if (L1square == true) {
			L1.SetActive (true);
		}
		if (L4square == true) {
			L4.SetActive (true);
		}
		if (L5square == true) {
			L5.SetActive (true);
		}
		if (L6square == true) {
			L6.SetActive (true);
		}
		if (L10square == true) {
			L10.SetActive (true);
		}
		if (L11square == true) {
			L11.SetActive (true);
		}
		if (L12square == true) {
			L12.SetActive (true);
		}
		if (L13square == true) {
			L13.SetActive (true);
		}
		if (L14square == true) {
			L14.SetActive (true);
		}
		if (Keysquare == true) {
			KeySquare.SetActive (true);
		}
		if (Endsquare == true) {
			EndSquare.SetActive (true);
		}
	}

	void Continue() { //create a function for continuing the game
		//set the MoveCamera and FlashLight scripts active again so the player may play the game
		GetComponent<MoveCamera>().enabled = true;
		GetComponent<FlashLight>().enabled = true;
		CancelInvoke ("PauseGame"); //cancel the pausegame function
		Time.timeScale = 1; //set timeScale back to 1
		Map.SetActive (false); //set the map inactive
	}


	void OnTriggerEnter (Collider other) { //when the wallChecker collides with a room trigger
		//create a series of if statements that set certain boolean vars to true when the player enters a room with the flashlight on
		if (other.gameObject.CompareTag ("A5") && FlashLight.lightSwitch == 1) {
			A5square = true;
		}
		if (other.gameObject.CompareTag ("A6") && FlashLight.lightSwitch == 1) {
			A6square = true;
		}
		if (other.gameObject.CompareTag ("A7") && FlashLight.lightSwitch == 1) {
			A7square = true;
		}
		if (other.gameObject.CompareTag ("A8") && FlashLight.lightSwitch == 1) {
			A8square = true;
		}
		if (other.gameObject.CompareTag ("A9") && FlashLight.lightSwitch == 1) {
			A9square = true;
		}
		if (other.gameObject.CompareTag ("A10") && FlashLight.lightSwitch == 1) {
			A10square = true;
		}
		if (other.gameObject.CompareTag ("A11") && FlashLight.lightSwitch == 1) {
			A11square = true;
		}
		if (other.gameObject.CompareTag ("A12") && FlashLight.lightSwitch == 1) {
			A12square = true;
		}
		if (other.gameObject.CompareTag ("A13") && FlashLight.lightSwitch == 1) {
			A13square = true;
		}
		if (other.gameObject.CompareTag ("A14") && FlashLight.lightSwitch == 1) {
			A14square = true;
		}
		if (other.gameObject.CompareTag ("B7") && FlashLight.lightSwitch == 1) {
			B7square = true;
		}
		if (other.gameObject.CompareTag ("B14") && FlashLight.lightSwitch == 1) {
			B14square = true;
		}
		if (other.gameObject.CompareTag ("C7") && FlashLight.lightSwitch == 1) {
			C7square = true;
		}
		if (other.gameObject.CompareTag ("C8") && FlashLight.lightSwitch == 1) {
			C8square = true;
		}
		if (other.gameObject.CompareTag ("C9") && FlashLight.lightSwitch == 1) {
			C9square = true;
		}
		if (other.gameObject.CompareTag ("C13") && FlashLight.lightSwitch == 1) {
			C13square = true;
		}
		if (other.gameObject.CompareTag ("C14") && FlashLight.lightSwitch == 1) {
			C14square = true;
		}
		if (other.gameObject.CompareTag ("D4") && FlashLight.lightSwitch == 1) {
			D4square = true;
		}
		if (other.gameObject.CompareTag ("D5") && FlashLight.lightSwitch == 1) {
			D5square = true;
		}
		if (other.gameObject.CompareTag ("D6") && FlashLight.lightSwitch == 1) {
			D6square = true;
		}
		if (other.gameObject.CompareTag ("D13") && FlashLight.lightSwitch == 1) {
			D13square = true;
		}
		if (other.gameObject.CompareTag ("E4") && FlashLight.lightSwitch == 1) {
			E4square = true;
		}
		if (other.gameObject.CompareTag ("E6") && FlashLight.lightSwitch == 1) {
			E6square = true;
		}
		if (other.gameObject.CompareTag ("E7") && FlashLight.lightSwitch == 1) {
			E7square = true;
		}
		if (other.gameObject.CompareTag ("E8") && FlashLight.lightSwitch == 1) {
			E8square = true;
		}
		if (other.gameObject.CompareTag ("E9") && FlashLight.lightSwitch == 1) {
			E9square = true;
		}
		if (other.gameObject.CompareTag ("E10") && FlashLight.lightSwitch == 1) {
			E10square = true;
		}
		if (other.gameObject.CompareTag ("E11") && FlashLight.lightSwitch == 1) {
			E11square = true;
		}
		if (other.gameObject.CompareTag ("E13") && FlashLight.lightSwitch == 1) {
			E13square = true;
		}
		if (other.gameObject.CompareTag ("E14") && FlashLight.lightSwitch == 1) {
			E14square = true;
		}
		if (other.gameObject.CompareTag ("F4") && FlashLight.lightSwitch == 1) {
			F4square = true;
		}
		if (other.gameObject.CompareTag ("F11") && FlashLight.lightSwitch == 1) {
			F11square = true;
		}
		if (other.gameObject.CompareTag ("F12") && FlashLight.lightSwitch == 1) {
			F12square = true;
		}
		if (other.gameObject.CompareTag ("F14") && FlashLight.lightSwitch == 1) {
			F14square = true;
		}
		if (other.gameObject.CompareTag ("G1") && FlashLight.lightSwitch == 1) {
			G1square = true;
		}
		if (other.gameObject.CompareTag ("G2") && FlashLight.lightSwitch == 1) {
			G2square = true;
		}
		if (other.gameObject.CompareTag ("G3") && FlashLight.lightSwitch == 1) {
			G3square = true;
		}
		if (other.gameObject.CompareTag ("G4") && FlashLight.lightSwitch == 1) {
			G4square = true;
		}
		if (other.gameObject.CompareTag ("G8") && FlashLight.lightSwitch == 1) {
			G8square = true;
		}
		if (other.gameObject.CompareTag ("G12") && FlashLight.lightSwitch == 1) {
			G12square = true;
		}
		if (other.gameObject.CompareTag ("G13") && FlashLight.lightSwitch == 1) {
			G13square = true;
		}
		if (other.gameObject.CompareTag ("G14") && FlashLight.lightSwitch == 1) {
			G14square = true;
		}
		if (other.gameObject.CompareTag ("H1") && FlashLight.lightSwitch == 1) {
			H1square = true;
		}
		if (other.gameObject.CompareTag ("H4") && FlashLight.lightSwitch == 1) {
			H4square = true;
		}
		if (other.gameObject.CompareTag ("H8") && FlashLight.lightSwitch == 1) {
			H8square = true;
		}
		if (other.gameObject.CompareTag ("H9") && FlashLight.lightSwitch == 1) {
			H9square = true;
		}
		if (other.gameObject.CompareTag ("H10") && FlashLight.lightSwitch == 1) {
			H10square = true;
		}
		if (other.gameObject.CompareTag ("H11") && FlashLight.lightSwitch == 1) {
			H11square = true;
		}
		if (other.gameObject.CompareTag ("H14") && FlashLight.lightSwitch == 1) {
			H14square = true;
		}
		if (other.gameObject.CompareTag ("I1") && FlashLight.lightSwitch == 1) {
			I1square = true;
		}
		if (other.gameObject.CompareTag ("I4") && FlashLight.lightSwitch == 1) {
			I4square = true;
		}
		if (other.gameObject.CompareTag ("I6")) {
            if (BatteryAlive == true)
            {
                Destroy(batteryPickup);
                FlashLight.battery = 100;
                BatteryAlive = false;
            }
            if (FlashLight.lightSwitch == 1) {
                I6square = true;
            }
		}
		if (other.gameObject.CompareTag ("I8") && FlashLight.lightSwitch == 1) {
			I8square = true;
		}
		if (other.gameObject.CompareTag ("I11") && FlashLight.lightSwitch == 1) {
			I11square = true;
		}
		if (other.gameObject.CompareTag ("I14") && FlashLight.lightSwitch == 1) {
			I14square = true;
		}
		if (other.gameObject.CompareTag ("J1") && FlashLight.lightSwitch == 1) {
			J1square = true;
		}
		if (other.gameObject.CompareTag ("J4") && FlashLight.lightSwitch == 1) {
			J4square = true;
		}
		if (other.gameObject.CompareTag ("J6") && FlashLight.lightSwitch == 1) {
			J6square = true;
		}
		if (other.gameObject.CompareTag ("J8") && FlashLight.lightSwitch == 1) {
			J8square = true;
		}
		if (other.gameObject.CompareTag ("J10") && FlashLight.lightSwitch == 1) {
			J10square = true;
		}
		if (other.gameObject.CompareTag ("J11") && FlashLight.lightSwitch == 1) {
			J11square = true;
		}
		if (other.gameObject.CompareTag ("J14") && FlashLight.lightSwitch == 1) {
			J14square = true;
		}
		if (other.gameObject.CompareTag ("K1") && FlashLight.lightSwitch == 1) {
			K1square = true;
		}
		if (other.gameObject.CompareTag ("K4") && FlashLight.lightSwitch == 1) {
			K4square = true;
		}
		if (other.gameObject.CompareTag ("K6") && FlashLight.lightSwitch == 1) {
			K6square = true;
		}
		if (other.gameObject.CompareTag ("K10") && FlashLight.lightSwitch == 1) {
			K10square = true;
		}
		if (other.gameObject.CompareTag ("K14") && FlashLight.lightSwitch == 1) {
			K14square = true;
		}
		if (other.gameObject.CompareTag ("L1") && FlashLight.lightSwitch == 1) {
			L1square = true;
		}
		if (other.gameObject.CompareTag ("L4") && FlashLight.lightSwitch == 1) {
			L4square = true;
		}
		if (other.gameObject.CompareTag ("L5") && FlashLight.lightSwitch == 1) {
			L5square = true;
		}
		if (other.gameObject.CompareTag ("L6") && FlashLight.lightSwitch == 1) {
			L6square = true;
		}
		if (other.gameObject.CompareTag ("L10") && FlashLight.lightSwitch == 1) {
			L10square = true;
		}
		if (other.gameObject.CompareTag ("L11") && FlashLight.lightSwitch == 1) {
			L11square = true;
		}
		if (other.gameObject.CompareTag ("L12") && FlashLight.lightSwitch == 1) {
			L12square = true;
		}
		if (other.gameObject.CompareTag ("L13") && FlashLight.lightSwitch == 1) {
			L13square = true;
		}
		if (other.gameObject.CompareTag ("L14") && FlashLight.lightSwitch == 1) {
			L14square = true;
		}
		if (other.gameObject.CompareTag ("Key")) { //if the player enters the key room trigger
			if (FlashLight.lightSwitch == 1) { //and their flashlight is on
				Keysquare = true; //set the Keysquare bool to true
                FlashLight.battery = 100;
			}
			AudioSource audio = GetComponent<AudioSource> (); //get audioSource component
			audio.PlayOneShot (keyNotice); //play the key soundclip
			KeyGet = 1; //set the KeyGet var to 1
			KeyIcon.SetActive (true); //set the KeyIcon active in the hierarchy
		}
		if (other.gameObject.CompareTag ("End")) { //if the player enters the end room trigger
			if (FlashLight.lightSwitch == 1) { //and their flashlight is on
				Endsquare = true; //set the Endsquare bool to true
			}
			if (KeyGet == 1) { //if the player has the key (KeyGet is 1)
				AudioSource audio = GetComponent<AudioSource> (); //get audioSource component
				audio.PlayOneShot (doorOpen); //play the door open soundclip
				Destroy (door); //destroy the "locked" door
				SceneManager.LoadScene ("Win"); //load the win scene
			}
		}
	}

}
