using UnityEngine;
using System.Collections;

public class GEO : MonoBehaviour
{

	public static GEO Instance{set; get;}
	public float latitude;
	public float longitude;

	private void Start(){
		Instance = this;
		DontDestroyOnLoad (gameObject);
		StartCoroutine (StartLocationService());

	}

	private IEnumerator StartLocationService(){
		if(!Input.location.isEnabledByUser){
			Debug.Log ("User has not enabled GPS");
			yield break;
		}

		Input.location.Start();
		int maxWait = 20;
		while(Input.location.status == LocationServiceStatus.Initializing && maxWait > 0){
			yield return new WaitForSeconds(1);
			maxWait--;


		}

		if(maxWait <= 0){
			Debug.Log("Timed out");
			yield break;
		}

		if(Input.location.status == LocationServiceStatus.Failed){
			Debug.Log("Unable to determin device location");
			yield break;
		}
		Debug.Log("Gettinghere");

		latitude = Input.location.lastData.latitude;
		longitude = Input.location.lastData.longitude;

		yield break;
	}


}