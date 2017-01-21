using UnityEngine;
using System.Collections;

public class CH10_PlayerSimpleAnimationController : MonoBehaviour {

	Animator mAni;
	Rigidbody mPlayerRigidBody;


	float fX=0f;
	float fY=0f;

	Vector3 movement;
	bool b_IsWarking;
	float speed =10f;


	private Vector2 mousePos ;
	private Vector3 screenPos ;


	// Use this for initialization
	void Start () {

		mPlayerRigidBody = gameObject.GetComponent<Rigidbody>();
		mAni = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {

		fX = Input.GetAxisRaw( "Horizontal");
		fY = Input.GetAxisRaw( "Vertical");



		movement.Set(fX , fY , 0);
		movement = movement.normalized * speed * Time.deltaTime;

		Debug.Log(   movement.y   );

		mPlayerRigidBody.MovePosition( transform.position + movement );
		//gameObject.transform.position += movement;
		//rigidbody2D.AddForce(force2D);

		if(fX !=0 || fY !=0) 
			mAni.SetBool("IsWalking", true);
		else
			mAni.SetBool("IsWalking", false);


	}
}
