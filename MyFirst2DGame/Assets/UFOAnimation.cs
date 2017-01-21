using UnityEngine;
using System.Collections;

public class UFOAnimation : MonoBehaviour {

	GameObject UFO;

	// Use this for initialization
	void Start () {
		UFO = GameObject.Find("UFO");
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown( KeyCode.T)  ){
			UFO.gameObject.GetComponent<Animator>().SetTrigger("IsHit");
		}
	
	}
}
