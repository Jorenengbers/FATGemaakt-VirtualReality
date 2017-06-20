using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VirtualRealityRaycasting : MonoBehaviour {

	public Camera camera;
	public Transform RadialProgressBar;
	public Transform Center;
	public Transform LoadingBar;

	public Transform RadialProgressBar2;
	public Transform Center2;
	public Transform LoadingBar2;

	public Canvas Target;

	public Transform InterfaceCanvas2;

	public Canvas DialogBox;

	bool exitVRScene;
	bool enterDialog;
	bool calibrate;


	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;

	void Start(){
		RadialProgressBar.GetComponent<Image> ().enabled = false;
		LoadingBar.GetComponent<Image> ().enabled = false;
		Center.GetComponent<Image> ().enabled = false;

		RadialProgressBar2.GetComponent<Image> ().enabled = false;
		LoadingBar2.GetComponent<Image> ().enabled = false;
		Center2.GetComponent<Image> ().enabled = false;

		DialogBox.gameObject.SetActive(false);

		currentAmount = 0;


		exitVRScene = false;
		enterDialog = false;
		calibrate = false;
	}




//	void Start()
//	{
//		camera = GetComponent<Camera>();
//	}

	void Update()
	{

		//Interactable Layer Raycast
		Ray ray = camera.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.CompareTag ("Interactable")) {
			print ("I'm looking at " + hit.transform.name);
			VisualCircleLoader ();
			enterDialog = true;
			//Destroy(hit.transform.gameObject);
		} else {
			if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.CompareTag ("ExitVR")) {

				print ("I'm looking at " + hit.transform.name);
				VisualCircleLoader ();
				exitVRScene = true;
				
			} else { 
				if (Physics.Raycast (ray, out hit) && hit.collider.gameObject.CompareTag ("Calibrate")) {
					print ("I'm looking at " + hit.transform.name);
					VisualCircleLoader ();
					calibrate = true;
				} else {
					print ("I'm looking at nothing!");
					ResetVisualCircleLoader ();
				}
			}
		}




	}

	IEnumerator Loader() {
		yield return new WaitForSeconds(5);
		VisualCircleLoader ();

	}

	void VisualCircleLoader(){
		//LoadingBar
		if (currentAmount < 100) {
			RadialProgressBar.GetComponent<Image> ().enabled = true;
			LoadingBar.GetComponent<Image> ().enabled = true;
			Center.GetComponent<Image> ().enabled = true;

			RadialProgressBar2.GetComponent<Image> ().enabled = true;
			LoadingBar2.GetComponent<Image> ().enabled = true;
			Center2.GetComponent<Image> ().enabled = true;

			currentAmount += speed * Time.deltaTime;

		} else {
			RadialProgressBar.GetComponent<Image> ().enabled = false;
			LoadingBar.GetComponent<Image> ().enabled = false;
			Center.GetComponent<Image> ().enabled = false;

			RadialProgressBar2.GetComponent<Image> ().enabled = false;
			LoadingBar2.GetComponent<Image> ().enabled = false;
			Center2.GetComponent<Image> ().enabled = false;

			currentAmount = 0;
		}

		LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
		LoadingBar2.GetComponent<Image>().fillAmount = currentAmount / 100;

		if(currentAmount >= 100 && enterDialog ==  true){
			Debug.Log ("100");
			DialogBox.gameObject.SetActive(true);
			Target.gameObject.SetActive(false);
			enterDialog = false;
		}



		if(currentAmount >= 100 && exitVRScene == true){
			Debug.Log ("100");

			exitVRScene = false;
			SceneManager.LoadScene("Map-demo2");

		}



		if(currentAmount >= 100 && calibrate == true){
			Debug.Log ("100");
		
			GameObject go = GameObject.Find("VRCamera");
			GyroMovement other = (GyroMovement) go.GetComponent(typeof(GyroMovement));
			other.CalibrateYAngle();
			calibrate = false;
		}
	}

	void ResetVisualCircleLoader(){
		RadialProgressBar.GetComponent<Image> ().enabled = false;
		LoadingBar.GetComponent<Image> ().enabled = false;
		Center.GetComponent<Image> ().enabled = false;

		RadialProgressBar2.GetComponent<Image> ().enabled = false;
		LoadingBar2.GetComponent<Image> ().enabled = false;
		Center2.GetComponent<Image> ().enabled = false;

		currentAmount = 0;
	}


}



