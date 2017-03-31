using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGrid : MonoBehaviour {

    string weaponType="laser";
    int upgLevel=0;

    public float rateOfFire;
    float fireDelay;
    bool shooting = true;
    Quaternion gunRotation = Quaternion.identity;

    public GameObject laserprojectile;
    GameObject barrelEnd;

	// Use this for initialization
	void Start () {
        barrelEnd = GameObject.Find("BarrelEnd");
		if ((upgLevel == 0)&&(weaponType=="laser"))
        {
            rateOfFire = 2;
        }
	}
	
	// Update is called once per frame
	void Update () {
        gunRotation.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        //move this to barrel script
        fireDelay = fireDelay + 0.1f;
        if ((shooting == true)&&(fireDelay>rateOfFire))
        {
            //spawn projectile at rate of fire
            Instantiate(laserprojectile, new Vector2(barrelEnd.transform.position.x, barrelEnd.transform.position.y), gunRotation);
            fireDelay = 0;
        }
		
	}
}
