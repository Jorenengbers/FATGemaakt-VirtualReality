using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void openVR(){
		Application.LoadLevel("VR-interface-demo");
	}




}
