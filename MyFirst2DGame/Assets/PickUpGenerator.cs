using UnityEngine;
using System.Collections;

public class PickUpGenerator : MonoBehaviour {

    public PickUpController pickUpPrefab;

    public int MinRandomCount = 3;
    public int MaxRandomCount = 10;

    public int GoodPickUpRate = 60;

	// Use this for initialization
	void Start () {

        int nRandomCount = Random.Range( MinRandomCount, MaxRandomCount);

        for (int i = 0; i < nRandomCount; i++)
        {
            int nRandPositionX = Random.Range(-10, 10) ;
            int nRandPositionY = Random.Range(-10, 10);


            PickUpController obj = GameObject.Instantiate(pickUpPrefab);

            if (Random.Range(0, 100) <= GoodPickUpRate)
                obj.initRole(PICKUP.PICUP_GOOD);
            else
                obj.initRole(PICKUP.PICUP_BAD);


          obj.name = "PickUp_" + i;
            obj.transform.position = new Vector3(nRandPositionX, nRandPositionY, 0);

            obj.transform.parent = this.transform; 
        }
        

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
