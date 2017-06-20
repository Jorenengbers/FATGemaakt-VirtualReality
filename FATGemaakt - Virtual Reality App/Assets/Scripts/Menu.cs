using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void openProfessorUitleg1(){
		SceneManager.LoadScene("Start01");
	}

	public void openVR(){
		SceneManager.LoadScene("VR-interface-demo");
	}

	public void openNamefield(){
		SceneManager.LoadScene("Start02");
	}

	public void openProfessorUitleg2(){
		SceneManager.LoadScene("Start03");
	}

	public void openMap(){
		SceneManager.LoadScene("Map-demo2");
	}


}
