﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnNovi : MonoBehaviour {

	public Canvas HotspotClickMessageCanvas;

	void OnMouseDown()
	{
		HotspotClickMessageCanvas.gameObject.SetActive(true);
	}

	public void closeHotspotClickMessage(){
		HotspotClickMessageCanvas.gameObject.SetActive(false);

	}
}
