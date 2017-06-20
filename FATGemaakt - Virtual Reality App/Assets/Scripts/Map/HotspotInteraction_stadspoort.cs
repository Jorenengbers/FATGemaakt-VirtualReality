using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotspotInteraction_stadspoort : MonoBehaviour {


	public GameObject vrbutton;

	void OnTriggerEnter(Collider obj)
	{
		if(obj.gameObject.name == "Hotspot_stadspoort"){
			Debug.Log ("Je bent bij een hotspot aangekomen");
			vrbutton.SetActive(true);
		}


	}

	void OnTriggerExit(Collider obj){
		vrbutton.SetActive(false);
	}


}
