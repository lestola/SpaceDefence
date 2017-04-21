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
    public GameObject cone;
    public GameObject barrelEnd;
    
    GameObject TargetedEnemy;
    Vector3 direction; // needed for LookAt 2D

	// Use this for initialization
	void Start () {
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

        TargetedEnemy = cone.GetComponent<TargetConeScript>().Targeted1;
        if ((TargetedEnemy != null)&& (TargetedEnemy.transform.position.y > -7.51) && (TargetedEnemy.transform.position.y < 7.51) && (TargetedEnemy.transform.position.x > -11.53) && (TargetedEnemy.transform.position.x < 11.53))
        {
            shooting = true;
            // LookAt 2D
            direction = TargetedEnemy.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 270;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
            shooting = false;
	}
}
