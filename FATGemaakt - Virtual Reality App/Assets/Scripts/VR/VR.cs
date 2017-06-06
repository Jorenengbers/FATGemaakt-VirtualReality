using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.SceneManagement;

public class VR : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void openSonar(){
		SceneManager.LoadScene("Map-demo2");
		SceneManager.UnloadScene("VR-interface-demo");
	}

	public void openVR(){
		SceneManager.LoadScene("VR-interface-demo");
		SceneManager.UnloadScene("Map-demo2");
	}

}
