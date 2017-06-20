using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {


	public void loadStadspoortVR() {
		
		SceneManager.LoadScene("StadspoortVR");

	}

	public void loadOudeKerkVR() {

		SceneManager.LoadScene("GrotekerkVR");

	}

	public void loadWilminkpleinVR() {

		SceneManager.LoadScene("WilminkpleinVR");

	}

	public void loadArchiefVR() {

		SceneManager.LoadScene("ArchiefVR");

	}

	public void loadKalanderstraatVR() {

		SceneManager.LoadScene("KalanderstraatVR");

	}



	public void loadSonar(){
		SceneManager.LoadScene("GameController");
	}
}
