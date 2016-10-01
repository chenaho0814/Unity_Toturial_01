using UnityEngine;
using System.Collections;

public class UFOController : MonoBehaviour {

	int i=0; 

	// Use this for initialization
	void Start () {
		Debug.Log("Hello Start()");
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Hello Update" + i );
		i=i+1;
	
	}
}
