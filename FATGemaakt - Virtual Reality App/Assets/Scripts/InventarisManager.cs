using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventarisManager : MonoBehaviour {

	public Canvas InventarisCanvas;


	public void openInventaris() {
		InventarisCanvas.gameObject.SetActive(true);

	}

	public void closeInventaris() {
		InventarisCanvas.gameObject.SetActive(false);
	}
}
