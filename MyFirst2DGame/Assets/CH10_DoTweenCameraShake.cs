using UnityEngine;
using System.Collections;
using DG.Tweening;

public class CH10_DoTweenCameraShake : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.T )){
			Camera.main.transform.DOShakePosition(0.5f , 1   );	
		}
	}
}
