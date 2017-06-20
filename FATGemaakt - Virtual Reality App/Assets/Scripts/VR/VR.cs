
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.SceneManagement;

public class VR : MonoBehaviour {

	public Canvas TurnDeviceMessageCanvas;

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void openSonar(){
		SceneManager.LoadScene("Map-demo2");
		SceneManager.UnloadScene("StadspoortVR");
	}

	public void openVR(){
		SceneManager.LoadScene("StadspoortVR");
		SceneManager.UnloadScene("Map-demo2");
	}

	public void closeTurnDeviceMessage(){
		TurnDeviceMessageCanvas.gameObject.SetActive(false);
	}

}
