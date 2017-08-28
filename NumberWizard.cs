using System.Collections;
using System.Collections.Generic;
using UnityEngine;

int max = 1000;
int min = 1;
int guess = 500;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Welcome To Number Wizard");
		print("Pick a number, but don't tell me");

		print("The highest number you can pick is " +max);
		print("The lowest number you can pick is " +min);

		print("Is the number higher or lower than " +guess);
		print("Up = higher, down = lower, return/enter = equal");

	}
	
	// Update is called once per frame
	void Update (){
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up arrow was pressed");
			min = guess;
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down arrow was pressed");
		} else (Input.GetKeyDown (KeyCode.Return)) {
			print("I won!");
		}
	} 
}



