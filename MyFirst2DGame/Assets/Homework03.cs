using UnityEngine;
using System.Collections;

public class Homework03 : MonoBehaviour {

	public GameObject UFO;

	bool bSizeChange =false;

	// Use this for initialization
	void Start () {
		UFO = GameObject.Find( "UFO" );
		//Debug.Log(  GetComponent<TalkToMe>().Message  );
	}

	public void ChangeUFOStatus(bool bChange){
		if(bSizeChange)
		{
			UFO.GetComponent< Transform >().localScale = new Vector3(3,3,3);
			UFO.GetComponent< SpriteRenderer>().color = Color.red;
		}
		else
		{
			UFO.GetComponent< Transform >().localScale = new Vector3(1,1,1);
			UFO.GetComponent< SpriteRenderer>().color = Color.white;
		}

	}

	// Update is called once per frame
	void Update () {

		if( Input.GetKeyDown(KeyCode.Return )   ){

			if(bSizeChange == false) bSizeChange =true;
			else
				if(bSizeChange == true) bSizeChange =false;

			//bSizeChange = !bSizeChange;

			ChangeUFOStatus( bSizeChange ) ; 
		}


	}

}
