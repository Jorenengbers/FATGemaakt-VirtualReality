using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGPSText : MonoBehaviour {

	public Text coordinates;

//	void Start(){
//		coordinates = GetComponent<Text>();
//		}

	private void Update(){
		coordinates.text = "Lat" + GEO.Instance.latitude.ToString() + "  lon:" + GEO.Instance.longitude.ToString();
	}
}
