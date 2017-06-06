﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {


	public void loadVR() {
		
		SceneManager.LoadScene("VR-interface-demo");

	}

	public void loadSonar(){
		SceneManager.LoadScene("GameController");
	}
}
