using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //call on the UI namespace of code for use in script
using UnityEngine.SceneManagement; //call on the SceneManagement namespace of code for use in script

public class FlashLight : MonoBehaviour {

	public GameObject flashy; //get the flashlight object
	public Text batteryDisplay; //create a slot in the inspector to use the batteryDisplay text
	public static int lightSwitch = 0; //integer that will change value if the light is "on" or "off"
	private int battery = 100; //create a var for amount of battery the flashlight has
	public float drainTime = 1; //create a float for the time it takes for the BatteryDrain function to repeat
	public AudioClip turnOn; //create a slot in the inspector for the turnOn audioclip
	public AudioClip turnOff; //create a slot in the inspector for the turnOff audioclip

	// Use this for initialization
	void Start () {
		battery = 100; //set battery to 100
		flashy.gameObject.SetActive (false); //the light is "off"
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (battery); //send a message to the console displaying the current value of the battery int
		batteryDisplay.text = "Flashlight Battery: " + battery + "%"; //update the text to display the current value of battery
		if (Input.GetKeyDown (KeyCode.Space) && lightSwitch == 0) { //press space bar and int equals 0
			AudioSource audio = GetComponent<AudioSource>(); //get audiosource component
			audio.PlayOneShot (turnOn); //pay the turnOn audio clip
			flashy.gameObject.SetActive (true); //the light is "on"
			lightSwitch++; //int changes to 1
			InvokeRepeating ("BatteryDrain", 0, drainTime); //invoke Battery Drain function at the interval of drainTime
			Debug.Log ("ON Light"); //tells console to display message when light is "on"
		} else if (Input.GetKeyDown (KeyCode.Space) && lightSwitch == 1) { //press space bar and int equals 1
			AudioSource audio = GetComponent<AudioSource>(); //get audiosource component
			audio.PlayOneShot (turnOff); //pay the turnOff audio clip 
			flashy.gameObject.SetActive (false); //set the light inactive ("off")
			lightSwitch--; //int changes to 0
			Debug.Log ("OFF Light"); //tells console to display message when light is "off"
			CancelInvoke("BatteryDrain"); //stop Battery Drain function
		}
		if (battery <= 0) { //if battery is less than or equal to 0
			SceneManager.LoadScene ("Lose"); //load losing screen
		}
	}

	void BatteryDrain(){
		battery = battery-4; //decrease battery by 1
		Debug.Log ("Running out of battery"); //send a message to the console saying the flashight is running out of battery
	}
}