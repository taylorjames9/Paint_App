using UnityEngine;
using System.Collections;
using TouchScript;
using TouchScript.Behaviors;
using TouchScript.Gestures;
using System;
using unitycoder_MobilePaint;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour {

	public unitycoder_MobilePaint.ColorUIManager ColorManager;


	void OnEnable(){
		GetComponent<PressGesture> ().Pressed += ChangeToMyColor;
	}

	void OnDisable(){

		GetComponent<PressGesture> ().Pressed -= ChangeToMyColor;

	}

	public void ChangeToMyColor(object sender, EventArgs e){


		ColorManager.SetCurrentColor (GetComponent<Button> ());


	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
