﻿using System.Collections;
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

    public GameObject StartIcon;
    public GameObject A5Icon;
    public GameObject A6Icon;
    public GameObject A7Icon;
    public GameObject A8Icon;
    public GameObject A9Icon;
    public GameObject A10Icon;
    public GameObject A11Icon;
    public GameObject A12Icon;
    public GameObject A13Icon;
    public GameObject A14Icon;
    public GameObject B7Icon;
    public GameObject B14Icon;
    public GameObject C7Icon;
    public GameObject C8Icon;
    public GameObject C9Icon;
    public GameObject C13Icon;
    public GameObject C14Icon;
    public GameObject D4Icon;
    public GameObject D5Icon;
    public GameObject D6Icon;
    public GameObject D13Icon;
    public GameObject E4Icon;
    public GameObject E6Icon;
    public GameObject E7Icon;
    public GameObject E8Icon;
    public GameObject E9Icon;
    public GameObject E10Icon;
    public GameObject E11Icon;
    public GameObject E13Icon;
    public GameObject E14Icon;
    public GameObject F4Icon;
    public GameObject F11Icon;
    public GameObject F12Icon;
    public GameObject F14Icon;
    public GameObject G1Icon;
    public GameObject G2Icon;
    public GameObject G3Icon;
    public GameObject G4Icon;
    public GameObject G8Icon;
    public GameObject G12Icon;
    public GameObject G13Icon;
    public GameObject G14Icon;
    public GameObject H1Icon;
    public GameObject H4Icon;
    public GameObject H8Icon;
    public GameObject H9Icon;
    public GameObject H10Icon;
    public GameObject H11Icon;
    public GameObject H14Icon;
    public GameObject I1Icon;
    public GameObject I4Icon;
    public GameObject I6Icon;
    public GameObject I8Icon;
    public GameObject I11Icon;
    public GameObject I14Icon;
    public GameObject J1Icon;
    public GameObject J4Icon;
    public GameObject J6Icon;
    public GameObject J8Icon;
    public GameObject J10Icon;
    public GameObject J11Icon;
    public GameObject J14Icon;
    public GameObject K1Icon;
    public GameObject K4Icon;
    public GameObject K6Icon;
    public GameObject K10Icon;
    public GameObject K14Icon;
    public GameObject L1Icon;
    public GameObject L4Icon;
    public GameObject L5Icon;
    public GameObject L6Icon;
    public GameObject L10Icon;
    public GameObject L11Icon;
    public GameObject L12Icon;
    public GameObject L13Icon;
    public GameObject L14Icon;
    public GameObject KeySquareIcon;
    public GameObject EndIcon;

    public GameObject KeyIcon; //create a slot in the inspector for the key icon

    public GameObject batteryPickup;
    public bool BatteryAlive;

	public AudioClip keyNotice; //create a slot in the inspector for the key soundclip
	public AudioClip doorOpen; //create a slot in the inspector for the door soundclip

	public static int KeyGet = 0; //set a var accesible by all scripts for whether or not the player has the key
	public GameObject door; //create a slot in the inpector for the door gameObject

	//create a set of bools determining if the player has visited these rooms with the flashlight on
	public static bool A5square;
	public static bool A6square;
    public static bool A7square;
	public static bool A8square;
	public static bool A9square;
	public static bool A10square;
	public static bool A11square;
	public static bool A12square;
	public static bool A13square;
	public static bool A14square;
	public static bool B7square;
	public static bool B14square;
	public static bool C7square;
	public static bool C8square;
	public static bool C9square;
	public static bool C13square;
	public static bool C14square;
	public static bool D4square;
	public static bool D5square;
	public static bool D6square;
	public static bool D13square;
	public static bool E4square;
	public static bool E6square;
	public static bool E7square;
	public static bool E8square;
	public static bool E9square;
	public static bool E10square;
	public static bool E11square;
	public static bool E13square;
	public static bool E14square;
	public static bool F4square;
	public static bool F11square;
	public static bool F12square;
	public static bool F14square;
	public static bool G1square;
	public static bool G2square;
	public static bool G3square;
	public static bool G4square;
	public static bool G8square;
	public static bool G12square;
	public static bool G13square;
	public static bool G14square;
	public static bool H1square;
	public static bool H4square;
	public static bool H8square;
	public static bool H9square;
	public static bool H10square;
	public static bool H11square;
	public static bool H14square;
	public static bool I1square;
	public static bool I4square;
	public static bool I6square;
	public static bool I8square;
	public static bool I11square;
	public static bool I14square;
	public static bool J1square;
	public static bool J4square;
	public static bool J6square;
	public static bool J8square;
	public static bool J10square;
	public static bool J11square;
	public static bool J14square;
	public static bool K1square;
	public static bool K4square;
	public static bool K6square;
	public static bool K10square;
	public static bool K14square;
	public static bool L1square;
	public static bool L4square;
	public static bool L5square;
	public static bool L6square;
	public static bool L10square;
	public static bool L11square;
	public static bool L12square;
	public static bool L13square;
	public static bool L14square;
	public static bool Keysquare;
	public static bool Endsquare;

    public static string PP;


	// Use this for initialization
	void Start () {

        KeyGet = 0;

		//set all map and other UI objects inactive
		Map.SetActive (false);
        StartIcon.SetActive(false);
		A5.SetActive (false);
        A5Icon.SetActive(false);
        A6.SetActive (false);
        A6Icon.SetActive(false);
        A7.SetActive (false);
        A7Icon.SetActive(false);
        A8.SetActive (false);
        A8Icon.SetActive(false);
        A9.SetActive (false);
        A9Icon.SetActive(false);
        A10.SetActive (false);
        A10Icon.SetActive(false);
        A11.SetActive (false);
        A11Icon.SetActive(false);
        A12.SetActive (false);
        A12Icon.SetActive(false);
        A13.SetActive (false);
        A13Icon.SetActive(false);
        A14.SetActive (false);
        A14Icon.SetActive(false);
        B7.SetActive (false);
        B7Icon.SetActive(false);
        B14.SetActive (false);
        B14Icon.SetActive(false);
        C7.SetActive (false);
        C7Icon.SetActive(false);
        C8.SetActive (false);
        C8Icon.SetActive(false);
        C9.SetActive (false);
        C9Icon.SetActive(false);
        C13.SetActive (false);
        C13Icon.SetActive(false);
        C14.SetActive (false);
        C14Icon.SetActive(false);
        D4.SetActive (false);
        D4Icon.SetActive(false);
        D5.SetActive (false);
        D5Icon.SetActive(false);
        D6.SetActive (false);
        D6Icon.SetActive(false);
		D13.SetActive (false);
        D13Icon.SetActive(false);
		E4.SetActive (false);
        E4Icon.SetActive(false);
        E6.SetActive (false);
        E6Icon.SetActive(false);
        E7.SetActive (false);
        E7Icon.SetActive(false);
        E8.SetActive (false);
        E8Icon.SetActive(false);
        E9.SetActive (false);
        E9Icon.SetActive(false);
        E10.SetActive (false);
        E10Icon.SetActive(false);
        E11.SetActive (false);
        E11Icon.SetActive(false);
        E13.SetActive (false);
        E13Icon.SetActive(false);
        E14.SetActive (false);
        E14Icon.SetActive(false);
        F4.SetActive (false);
        F4Icon.SetActive(false);
        F11.SetActive (false);
        F11Icon.SetActive(false);
        F12.SetActive (false);
        F12Icon.SetActive(false);
        F14.SetActive (false);
        F14Icon.SetActive(false);
        G1.SetActive (false);
        G1Icon.SetActive(false);
        G2.SetActive (false);
        G2Icon.SetActive(false);
        G3.SetActive (false);
        G3Icon.SetActive(false);
        G4.SetActive (false);
        G4Icon.SetActive(false);
        G8.SetActive (false);
        G8Icon.SetActive(false);
        G12.SetActive (false);
        G12Icon.SetActive(false);
        G13.SetActive (false);
        G13Icon.SetActive(false);
        G14.SetActive (false);
        G14Icon.SetActive(false);
        H1.SetActive (false);
        H1Icon.SetActive(false);
        H4.SetActive (false);
        H4Icon.SetActive(false);
        H8.SetActive (false);
        H8Icon.SetActive(false);
        H9.SetActive (false);
        H9Icon.SetActive(false);
        H10.SetActive (false);
        H10Icon.SetActive(false);
        H11.SetActive (false);
        H11Icon.SetActive(false);
        H14.SetActive (false);
        H14Icon.SetActive(false);
        I1.SetActive (false);
        I1Icon.SetActive(false);
        I4.SetActive (false);
        I4Icon.SetActive(false);
        I6.SetActive (false);
        I6Icon.SetActive(false);
        I8.SetActive (false);
        I8Icon.SetActive(false);
        I11.SetActive (false);
        I11Icon.SetActive(false);
        I14.SetActive (false);
        I14Icon.SetActive(false);
        J1.SetActive (false);
        J1Icon.SetActive(false);
        J4.SetActive (false);
        J4Icon.SetActive(false);
        J6.SetActive (false);
        J6Icon.SetActive(false);
        J8.SetActive (false);
        J8Icon.SetActive(false);
        J10.SetActive (false);
        J10Icon.SetActive(false);
        J11.SetActive (false);
        J11Icon.SetActive(false);
        J14.SetActive (false);
        J14Icon.SetActive(false);
        K1.SetActive (false);
        K1Icon.SetActive(false);
        K4.SetActive (false);
        K4Icon.SetActive(false);
        K6.SetActive (false);
        K6Icon.SetActive(false);
        K10.SetActive (false);
        K10Icon.SetActive(false);
        K14.SetActive (false);
        K14Icon.SetActive(false);
        L1.SetActive (false);
        L1Icon.SetActive(false);
        L4.SetActive (false);
        L4Icon.SetActive(false);
        L5.SetActive (false);
        L5Icon.SetActive(false);
        L6.SetActive (false);
        L6Icon.SetActive(false);
        L10.SetActive (false);
        L10Icon.SetActive(false);
        L11.SetActive (false);
        L11Icon.SetActive(false);
        L12.SetActive (false);
        L12Icon.SetActive(false);
        L13.SetActive (false);
        L13Icon.SetActive(false);
        L14.SetActive (false);
        L14Icon.SetActive(false);
        EndSquare.SetActive (false);
        EndIcon.SetActive(false);
        KeySquare.SetActive (false);
        KeySquareIcon.SetActive(false);
        KeyIcon.SetActive (false);

        PP = "Start";

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
        if (PP == "Start")
        {
            StartIcon.SetActive(true);
        }
        else if (PP != "Start")
        {
            StartIcon.SetActive(false);
        }
        if (PP =="A5")
        {
            A5Icon.SetActive(true);
        }
        else if (PP != "A5")
        {
            A5Icon.SetActive(false);
        }
        if (PP == "A6")
        {
            A6Icon.SetActive(true);
        }
        else if (PP != "A6")
        {
            A6Icon.SetActive(false);
        }
        if (PP =="A7")
        {
            A7Icon.SetActive(true);
        }
        else if (PP != "A7")
        {
            A7Icon.SetActive(false);
        }
        if (PP == "A8")
        {
            A8Icon.SetActive(true);
        }
        else if (PP != "A8")
        {
            A8Icon.SetActive(false);
        }
        if (PP == "A9")
        {
            A9Icon.SetActive(true);
        }
        else if (PP != "A9")
        {
            A9Icon.SetActive(false);
        }
        if (PP == "A10")
        {
            A10Icon.SetActive(true);
        }
        else if (PP != "A10")
        {
            A10Icon.SetActive(false);
        }
        if (PP == "A11")
        {
            A11Icon.SetActive(true);
        }
        else if (PP != "A11")
        {
            A11Icon.SetActive(false);
        }
        if (PP == "A12")
        {
            A12Icon.SetActive(true);
        }
        else if (PP != "A12")
        {
            A12Icon.SetActive(false);
        }
        if (PP == "A13")
        {
            A13Icon.SetActive(true);
        }
        else if (PP != "A13")
        {
            A13Icon.SetActive(false);
        }
        if (PP == "A14")
        {
            A14Icon.SetActive(true);
        }
        else if (PP != "A14")
        {
            A14Icon.SetActive(false);
        }
        if (PP == "B7")
        {
            B7Icon.SetActive(true);
        }
        else if (PP != "B7")
        {
            B7Icon.SetActive(false);
        }
        if (PP == "B14")
        {
            B14Icon.SetActive(true);
        }
        else if (PP != "B14")
        {
            B14Icon.SetActive(false);
        }
        if (PP == "C7")
        {
            C7Icon.SetActive(true);
        }
        else if (PP != "C7")
        {
            C7Icon.SetActive(false);
        }
        if (PP == "C8")
        {
            C8Icon.SetActive(true);
        }
        else if (PP != "C8")
        {
            C8Icon.SetActive(false);
        }
        if (PP == "C9")
        {
            C9Icon.SetActive(true);
        }
        else if (PP != "C9")
        {
            C9Icon.SetActive(false);
        }
        if (PP == "C13")
        {
            C13Icon.SetActive(true);
        }
        else if (PP != "C13")
        {
            C13Icon.SetActive(false);
        }
        if (PP == "C14")
        {
            C14Icon.SetActive(true);
        }
        else if (PP != "C14")
        {
            C14Icon.SetActive(false);
        }
        if (PP == "D4")
        {
            D4Icon.SetActive(true);
        }
        else if (PP != "D4")
        {
            D4Icon.SetActive(false);
        }
        if (PP == "D5")
        {
            D5Icon.SetActive(true);
        }
        else if (PP != "D5")
        {
            D5Icon.SetActive(false);
        }
        if (PP == "D6")
        {
            D6Icon.SetActive(true);
        }
        else if (PP != "D6")
        {
            D6Icon.SetActive(false);
        }
        if (PP == "D13")
        {
            D13Icon.SetActive(true);
        }
        else if (PP != "D13")
        {
            D13Icon.SetActive(false);
        }
        if (PP == "E4")
        {
            E4Icon.SetActive(true);
        }
        else if (PP != "E4")
        {
            E4Icon.SetActive(false);
        }
        if (PP == "E6")
        {
            E6Icon.SetActive(true);
        }
        else if (PP != "E6")
        {
            E6Icon.SetActive(false);
        }
        if (PP == "E7")
        {
            E7Icon.SetActive(true);
        }
        else if (PP != "E7")
        {
            E7Icon.SetActive(false);
        }
        if (PP == "E8")
        {
            E8Icon.SetActive(true);
        }
        else if (PP != "E8")
        {
            E8Icon.SetActive(false);
        }
        if (PP == "E9")
        {
            E9Icon.SetActive(true);
        }
        else if (PP != "E9")
        {
            E9Icon.SetActive(false);
        }
        if (PP == "E10")
        {
            E10Icon.SetActive(true);
        }
        else if (PP != "E10")
        {
            E10Icon.SetActive(false);
        }
        if (PP == "E11")
        {
            E11Icon.SetActive(true);
        }
        else if (PP != "E11")
        {
            E11Icon.SetActive(false);
        }
        if (PP == "E13")
        {
            E13Icon.SetActive(true);
        }
        else if (PP != "E13")
        {
            E13Icon.SetActive(false);
        }
        if (PP == "E14")
        {
            E14Icon.SetActive(true);
        }
        else if (PP != "E14")
        {
            E14Icon.SetActive(false);
        }
        if (PP == "F4")
        {
            F4Icon.SetActive(true);
        }
        else if (PP != "F4")
        {
            F4Icon.SetActive(false);
        }
        if (PP == "F11")
        {
            F11Icon.SetActive(true);
        }
        else if (PP != "F11")
        {
            F11Icon.SetActive(false);
        }
        if (PP == "F12")
        {
            F12Icon.SetActive(true);
        }
        else if (PP != "F12")
        {
            F12Icon.SetActive(false);
        }
        if (PP == "F14")
        {
            F14Icon.SetActive(true);
        }
        else if (PP != "F14")
        {
            F14Icon.SetActive(false);
        }
        if (PP == "G1")
        {
            G1Icon.SetActive(true);
        }
        else if (PP != "G1")
        {
            G1Icon.SetActive(false);
        }
        if (PP == "G2")
        {
            G2Icon.SetActive(true);
        }
        else if (PP != "G2")
        {
            G2Icon.SetActive(false);
        }
        if (PP == "G3")
        {
            G3Icon.SetActive(true);
        }
        else if (PP != "G3")
        {
            G3Icon.SetActive(false);
        }
        if (PP == "G4")
        {
            G4Icon.SetActive(true);
        }
        else if (PP != "G4")
        {
            G4Icon.SetActive(false);
        }
        if (PP == "G8")
        {
            G8Icon.SetActive(true);
        }
        else if (PP != "G8")
        {
            G8Icon.SetActive(false);
        }
        if (PP == "G12")
        {
            G12Icon.SetActive(true);
        }
        else if (PP != "G12")
        {
            G12Icon.SetActive(false);
        }
        if (PP == "G13")
        {
            G13Icon.SetActive(true);
        }
        else if (PP != "G13")
        {
            G13Icon.SetActive(false);
        }
        if (PP == "G14")
        {
            G14Icon.SetActive(true);
        }
        else if (PP != "G14")
        {
            G14Icon.SetActive(false);
        }
        if (PP == "H1")
        {
            H1Icon.SetActive(true);
        }
        else if (PP != "H1")
        {
            H1Icon.SetActive(false);
        }
        if (PP == "H4")
        {
            H4Icon.SetActive(true);
        }
        else if (PP != "H4")
        {
            H4Icon.SetActive(false);
        }
        if (PP == "H8")
        {
            H8Icon.SetActive(true);
        }
        else if (PP != "H8")
        {
            H8Icon.SetActive(false);
        }
        if (PP == "H9")
        {
            H9Icon.SetActive(true);
        }
        else if (PP != "H9")
        {
            H9Icon.SetActive(false);
        }
        if (PP == "H10")
        {
            H10Icon.SetActive(true);
        }
        else if (PP != "H10")
        {
            H10Icon.SetActive(false);
        }
        if (PP == "H11")
        {
            H11Icon.SetActive(true);
        }
        else if (PP != "H11")
        {
            H11Icon.SetActive(false);
        }
        if (PP == "H14")
        {
            H14Icon.SetActive(true);
        }
        else if (PP != "H14")
        {
            H14Icon.SetActive(false);
        }
        if (PP == "I1")
        {
            I1Icon.SetActive(true);
        }
        else if (PP != "I1")
        {
            I1Icon.SetActive(false);
        }
        if (PP == "I4")
        {
            I4Icon.SetActive(true);
        }
        else if (PP != "I4")
        {
            I4Icon.SetActive(false);
        }
        if (PP == "I6")
        {
            I6Icon.SetActive(true);
        }
        else if (PP != "I6")
        {
            I6Icon.SetActive(false);
        }
        if (PP == "I8")
        {
            I8Icon.SetActive(true);
        }
        else if (PP != "I8")
        {
            I8Icon.SetActive(false);
        }
        if (PP == "Key")
        {
            KeySquareIcon.SetActive(true);
        }
        if (PP == "I11")
        {
            I11Icon.SetActive(true);
        }
        else if (PP != "I11")
        {
            I11Icon.SetActive(false);
        }
        if (PP == "I14")
        {
            I14Icon.SetActive(true);
        }
        else if (PP != "I14")
        {
            I14Icon.SetActive(false);
        }
        if (PP == "J1")
        {
            J1Icon.SetActive(true);
        }
        else if (PP != "J1")
        {
            J1Icon.SetActive(false);
        }
        if (PP == "J4")
        {
            J4Icon.SetActive(true);
        }
        else if (PP != "J4")
        {
            J4Icon.SetActive(false);
        }
        if (PP == "J6")
        {
            J6Icon.SetActive(true);
        }
        else if (PP != "J6")
        {
            J6Icon.SetActive(false);
        }
        if (PP == "J8")
        {
            J8Icon.SetActive(true);
        }
        else if (PP != "J8")
        {
            J8Icon.SetActive(false);
        }
        if (PP == "J10")
        {
            J10Icon.SetActive(true);
        }
        else if (PP != "J10")
        {
            J10Icon.SetActive(false);
        }
        if (PP == "J11")
        {
            J11Icon.SetActive(true);
        }
        else if (PP != "J11")
        {
            J11Icon.SetActive(false);
        }
        if (PP == "J14")
        {
            J14Icon.SetActive(true);
        }
        else if (PP != "J14")
        {
            J14Icon.SetActive(false);
        }
        if (PP == "K1")
        {
            K1Icon.SetActive(true);
        }
        else if (PP != "K1")
        {
            K1Icon.SetActive(false);
        }
        if (PP == "K4")
        {
            K4Icon.SetActive(true);
        }
        else if (PP != "K4")
        {
            K4Icon.SetActive(false);
        }
        if (PP == "K6")
        {
            K6Icon.SetActive(true);
        }
        else if (PP != "K6")
        {
            K6Icon.SetActive(false);
        }
        if (PP == "K10")
        {
            K10Icon.SetActive(true);
        }
        else if (PP != "K10")
        {
            K10Icon.SetActive(false);
        }
        if (PP == "K14")
        {
            K14Icon.SetActive(true);
        }
        else if (PP != "K14")
        {
            K14Icon.SetActive(false);
        }
        if (PP == "L1")
        {
            L1Icon.SetActive(true);
        }
        else if (PP != "L1")
        {
            L1Icon.SetActive(false);
        }
        if (PP == "L4")
        {
            L4Icon.SetActive(true);
        }
        else if (PP != "L4")
        {
            L4Icon.SetActive(false);
        }
        if (PP == "L5")
        {
            L5Icon.SetActive(true);
        }
        else if (PP != "L5")
        {
            L5Icon.SetActive(false);
        }
        if (PP == "L6")
        {
            L6Icon.SetActive(true);
        }
        else if (PP != "L6")
        {
            L6Icon.SetActive(false);
        }
        if (PP == "L10")
        {
            L10Icon.SetActive(true);
        }
        else if (PP != "L10")
        {
            L10Icon.SetActive(false);
        }
        if (PP == "L11")
        {
            L11Icon.SetActive(true);
        }
        else if (PP != "L11")
        {
            L11Icon.SetActive(false);
        }
        if (PP == "L12")
        {
            L12Icon.SetActive(true);
        }
        else if (PP != "L12")
        {
            L12Icon.SetActive(false);
        }
        if (PP == "L13")
        {
            L13Icon.SetActive(true);
        }
        else if (PP != "L13")
        {
            L13Icon.SetActive(false);
        }
        if (PP == "L14")
        {
            L14Icon.SetActive(true);
        }
        else if (PP != "L14")
        {
            L14Icon.SetActive(false);
        }
        if (PP == "End")
        {
            EndIcon.SetActive(true);
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
		if (other.gameObject.CompareTag ("A5")) {
            PP = "A5";
            if (FlashLight.lightSwitch == 1)
            {
                A5square = true;
            }
		}
        if (other.gameObject.CompareTag("A6"))
        {
            PP = "A6";
            if (FlashLight.lightSwitch == 1)
            {
                A6square = true;
            }
        }
        if (other.gameObject.CompareTag("A7"))
        {
            PP = "A7";
            if (FlashLight.lightSwitch == 1)
            {
                A7square = true;
            }
        }
        if (other.gameObject.CompareTag("A8"))
        {
            PP = "A8";
            if (FlashLight.lightSwitch == 1)
            {
                A8square = true;
            }
        }
        if (other.gameObject.CompareTag("A9"))
        {
            PP = "A9";
            if (FlashLight.lightSwitch == 1)
            {
                A9square = true;
            }
        }
        if (other.gameObject.CompareTag("A10"))
        {
            PP = "A10";
            if (FlashLight.lightSwitch == 1)
            {
                A10square = true;
            }
        }
        if (other.gameObject.CompareTag("A11"))
        {
            PP = "A11";
            if (FlashLight.lightSwitch == 1)
            {
                A11square = true;
            }
        }
        if (other.gameObject.CompareTag("A12"))
        {
            PP = "A12";
            if (FlashLight.lightSwitch == 1)
            {
                A12square = true;
            }
        }
        if (other.gameObject.CompareTag("A13"))
        {
            PP = "A13";
            if (FlashLight.lightSwitch == 1)
            {
                A13square = true;
            }
        }
        if (other.gameObject.CompareTag("A14"))
        {
            PP = "A14";
            if (FlashLight.lightSwitch == 1)
            {
                A14square = true;
            }
        }
        if (other.gameObject.CompareTag("B7"))
        {
            PP = "B7";
            if (FlashLight.lightSwitch == 1)
            {
                B7square = true;
            }
        }
        if (other.gameObject.CompareTag("B14"))
        {
            PP = "B14";
            if (FlashLight.lightSwitch == 1)
            {
                B14square = true;
            }
        }
        if (other.gameObject.CompareTag("C7"))
        {
            PP = "C7";
            if (FlashLight.lightSwitch == 1)
            {
                C7square = true;
            }
        }
        if (other.gameObject.CompareTag("C8"))
        {
            PP = "C8";
            if (FlashLight.lightSwitch == 1)
            {
                C8square = true;
            }
        }
        if (other.gameObject.CompareTag("C9"))
        {
            PP = "C9";
            if (FlashLight.lightSwitch == 1)
            {
                C9square = true;
            }
        }
        if (other.gameObject.CompareTag("C13"))
        {
            PP = "C13";
            if (FlashLight.lightSwitch == 1)
            {
                C13square = true;
            }
        }
        if (other.gameObject.CompareTag("C14"))
        {
            PP = "C14";
            if (FlashLight.lightSwitch == 1)
            {
                C14square = true;
            }
        }
        if (other.gameObject.CompareTag("D4"))
        {
            PP = "D4";
            if (FlashLight.lightSwitch == 1)
            {
                D4square = true;
            }
        }
        if (other.gameObject.CompareTag("D5"))
        {
            PP = "D5";
            if (FlashLight.lightSwitch == 1)
            {
                D5square = true;
            }
        }
        if (other.gameObject.CompareTag("D6"))
        {
            PP = "D6";
            if (FlashLight.lightSwitch == 1)
            {
                D6square = true;
            }
        }
        if (other.gameObject.CompareTag("D13"))
        {
            PP = "D13";
            if (FlashLight.lightSwitch == 1)
            {
                D13square = true;
            }
        }
        if (other.gameObject.CompareTag("E4"))
        {
            PP = "E4";
            if (FlashLight.lightSwitch == 1)
            {
                E4square = true;
            }
        }
        if (other.gameObject.CompareTag("E6"))
        {
            PP = "E6";
            if (FlashLight.lightSwitch == 1)
            {
                E6square = true;
            }
        }
        if (other.gameObject.CompareTag("E7"))
        {
            PP = "E7";
            if (FlashLight.lightSwitch == 1)
            {
                E7square = true;
            }
        }
        if (other.gameObject.CompareTag("E8"))
        {
            PP = "E8";
            if (FlashLight.lightSwitch == 1)
            {
                E8square = true;
            }
        }
        if (other.gameObject.CompareTag("E9"))
        {
            PP = "E9";
            if (FlashLight.lightSwitch == 1)
            {
                E9square = true;
            }
        }
        if (other.gameObject.CompareTag("E10"))
        {
            PP = "E10";
            if (FlashLight.lightSwitch == 1)
            {
                E10square = true;
            }
        }
        if (other.gameObject.CompareTag("E11"))
        {
            PP = "E11";
            if (FlashLight.lightSwitch == 1)
            {
                E11square = true;
            }
        }
        if (other.gameObject.CompareTag("E13"))
        {
            PP = "E13";
            if (FlashLight.lightSwitch == 1)
            {
                E13square = true;
            }
        }
        if (other.gameObject.CompareTag("E14"))
        {
            PP = "E14";
            if (FlashLight.lightSwitch == 1)
            {
                E14square = true;
            }
        }
        if (other.gameObject.CompareTag("F4"))
        {
            PP = "F4";
            if (FlashLight.lightSwitch == 1)
            {
                F4square = true;
            }
        }
        if (other.gameObject.CompareTag("F11"))
        {
            PP = "F11";
            if (FlashLight.lightSwitch == 1)
            {
                F11square = true;
            }
        }
        if (other.gameObject.CompareTag("F12"))
        {
            PP = "F12";
            if (FlashLight.lightSwitch == 1)
            {
                F12square = true;
            }
        }
        if (other.gameObject.CompareTag("F14"))
        {
            PP = "F14";
            if (FlashLight.lightSwitch == 1)
            {
                F14square = true;
            }
        }
        if (other.gameObject.CompareTag("G1"))
        {
            PP = "G1";
            if (FlashLight.lightSwitch == 1)
            {
                G1square = true;
            }
        }
        if (other.gameObject.CompareTag("G2"))
        {
            PP = "G2";
            if (FlashLight.lightSwitch == 1)
            {
                G2square = true;
            }
        }
        if (other.gameObject.CompareTag("G3"))
        {
            PP = "G3";
            if (FlashLight.lightSwitch == 1)
            {
                G3square = true;
            }
        }
        if (other.gameObject.CompareTag("G4"))
        {
            PP = "G4";
            if (FlashLight.lightSwitch == 1)
            {
                G4square = true;
            }
        }
        if (other.gameObject.CompareTag("G8"))
        {
            PP = "G8";
            if (FlashLight.lightSwitch == 1)
            {
                G8square = true;
            }
        }
        if (other.gameObject.CompareTag("G12"))
        {
            PP = "G12";
            if (FlashLight.lightSwitch == 1)
            {
                G12square = true;
            }
        }
        if (other.gameObject.CompareTag("G13"))
        {
            PP = "G13";
            if (FlashLight.lightSwitch == 1)
            {
                G13square = true;
            }
        }
        if (other.gameObject.CompareTag("G14"))
        {
            PP = "G14";
            if (FlashLight.lightSwitch == 1)
            {
                G14square = true;
            }
        }
        if (other.gameObject.CompareTag("H1"))
        {
            PP = "H1";
            if (FlashLight.lightSwitch == 1)
            {
                H1square = true;
            }
        }
        if (other.gameObject.CompareTag("H4"))
        {
            PP = "H4";
            if (FlashLight.lightSwitch == 1)
            {
                H4square = true;
            }
        }
        if (other.gameObject.CompareTag("H8"))
        {
            PP = "H8";
            if (FlashLight.lightSwitch == 1)
            {
                H8square = true;
            }
        }
        if (other.gameObject.CompareTag("H9"))
        {
            PP = "H9";
            if (FlashLight.lightSwitch == 1)
            {
                H1square = true;
            }
        }
        if (other.gameObject.CompareTag("H10"))
        {
            PP = "H10";
            if (FlashLight.lightSwitch == 1)
            {
                H10square = true;
            }
        }
        if (other.gameObject.CompareTag("H11"))
        {
            PP = "H11";
            if (FlashLight.lightSwitch == 1)
            {
                H11square = true;
            }
        }
        if (other.gameObject.CompareTag("H14"))
        {
            PP = "H14";
            if (FlashLight.lightSwitch == 1)
            {
                H14square = true;
            }
        }
        if (other.gameObject.CompareTag("I1"))
        {
            PP = "I1";
            if (FlashLight.lightSwitch == 1)
            {
                I1square = true;
            }
        }
        if (other.gameObject.CompareTag("I4"))
        {
            PP = "I4";
            if (FlashLight.lightSwitch == 1)
            {
                I4square = true;
            }
        }
        if (other.gameObject.CompareTag ("I6")) {
            PP = "I6";
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
        if (other.gameObject.CompareTag("I8"))
        {
            PP = "I8";
            if (FlashLight.lightSwitch == 1)
            {
                I8square = true;
            }
        }
        if (other.gameObject.CompareTag("I11"))
        {
            PP = "I11";
            if (FlashLight.lightSwitch == 1)
            {
                I11square = true;
            }
        }
        if (other.gameObject.CompareTag("I14"))
        {
            PP = "I14";
            if (FlashLight.lightSwitch == 1)
            {
                I14square = true;
            }
        }
        if (other.gameObject.CompareTag("J1"))
        {
            PP = "J1";
            if (FlashLight.lightSwitch == 1)
            {
                J1square = true;
            }
        }
        if (other.gameObject.CompareTag("J4"))
        {
            PP = "J4";
            if (FlashLight.lightSwitch == 1)
            {
                J4square = true;
            }
        }
        if (other.gameObject.CompareTag("J6"))
        {
            PP = "J6";
            if (FlashLight.lightSwitch == 1)
            {
                J6square = true;
            }
        }
        if (other.gameObject.CompareTag("J8"))
        {
            PP = "J8";
            if (FlashLight.lightSwitch == 1)
            {
                J8square = true;
            }
        }
        if (other.gameObject.CompareTag("J10"))
        {
            PP = "J10";
            if (FlashLight.lightSwitch == 1)
            {
                J10square = true;
            }
        }
        if (other.gameObject.CompareTag("J11"))
        {
            PP = "J11";
            if (FlashLight.lightSwitch == 1)
            {
                J10square = true;
            }
        }
        if (other.gameObject.CompareTag("J14"))
        {
            PP = "J14";
            if (FlashLight.lightSwitch == 1)
            {
                J14square = true;
            }
        }
        if (other.gameObject.CompareTag("K1"))
        {
            PP = "K1";
            if (FlashLight.lightSwitch == 1)
            {
                K1square = true;
            }
        }
        if (other.gameObject.CompareTag("K4"))
        {
            PP = "K4";
            if (FlashLight.lightSwitch == 1)
            {
                K4square = true;
            }
        }
        if (other.gameObject.CompareTag("K6"))
        {
            PP = "K6";
            if (FlashLight.lightSwitch == 1)
            {
                K6square = true;
            }
        }
        if (other.gameObject.CompareTag("K10"))
        {
            PP = "K10";
            if (FlashLight.lightSwitch == 1)
            {
                K10square = true;
            }
        }
        if (other.gameObject.CompareTag("K14"))
        {
            PP = "K14";
            if (FlashLight.lightSwitch == 1)
            {
                K14square = true;
            }
        }
        if (other.gameObject.CompareTag("L1"))
        {
            PP = "L1";
            if (FlashLight.lightSwitch == 1)
            {
                L1square = true;
            }
        }
        if (other.gameObject.CompareTag("L4"))
        {
            PP = "L4";
            if (FlashLight.lightSwitch == 1)
            {
                L4square = true;
            }
        }
        if (other.gameObject.CompareTag("L5"))
        {
            PP = "L5";
            if (FlashLight.lightSwitch == 1)
            {
                L5square = true;
            }
        }
        if (other.gameObject.CompareTag("L6"))
        {
            PP = "L6";
            if (FlashLight.lightSwitch == 1)
            {
                L6square = true;
            }
        }
        if (other.gameObject.CompareTag("L10"))
        {
            PP = "L10";
            if (FlashLight.lightSwitch == 1)
            {
                L10square = true;
            }
        }
        if (other.gameObject.CompareTag("L11"))
        {
            PP = "L11";
            if (FlashLight.lightSwitch == 1)
            {
                L11square = true;
            }
        }
        if (other.gameObject.CompareTag("L12"))
        {
            PP = "L12";
            if (FlashLight.lightSwitch == 1)
            {
                L12square = true;
            }
        }
        if (other.gameObject.CompareTag("L13"))
        {
            PP = "L13";
            if (FlashLight.lightSwitch == 1)
            {
                L13square = true;
            }
        }
        if (other.gameObject.CompareTag("L14"))
        {
            PP = "L14";
            if (FlashLight.lightSwitch == 1)
            {
                L14square = true;
            }
        }
        if (other.gameObject.CompareTag ("Key")) { //if the player enters the key room trigger
            PP = "Key";
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
            PP = "End";
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
