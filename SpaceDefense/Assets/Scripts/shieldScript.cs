using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldScript : MonoBehaviour {

    public int shieldPower = 0;
    public int maxShieldPower = 5;
    public float powerUpDelayDefault = 10.0f;
    float powerUpDelay;
   



    // Use this for initialization
    void Start () {
		
	}


    // Update is called once per frame
    void Update () {

        
        powerUpDelay = powerUpDelay - 0.1f;

        if ((powerUpDelay < 0)&&(shieldPower < maxShieldPower)){
            //add one to shield every second (or whatever setted to powerUpDelayDefault)
            shieldPower += 1;
            powerUpDelay = powerUpDelayDefault;
        }

        if (shieldPower == 0)
        {
           
            // store a reference to the SpriteRenderer on the current GameObject
            SpriteRenderer spRend = gameObject.transform.GetComponent<SpriteRenderer>();
            // copy the SpriteRenderer's color property
            Color col = spRend.color;
            //  change col's alpha value (0 = invisible, 1 = fully opaque)
            col.a = 0.0f; // 0.5f = half transparent
                          // change the SpriteRenderer's color property to match the copy with the altered alpha value
            spRend.color = col;

        }
        else if (shieldPower == 1)
        {

            // store a reference to the SpriteRenderer on the current GameObject
            SpriteRenderer spRend = gameObject.transform.GetComponent<SpriteRenderer>();
            // copy the SpriteRenderer's color property
            Color col = spRend.color;
            //  change col's alpha value (0 = invisible, 1 = fully opaque)
            col.a = 0.2f; // 0.5f = half transparent
                          // change the SpriteRenderer's color property to match the copy with the altered alpha value
            spRend.color = col;

        }
        else if (shieldPower == 2)
        {

            // store a reference to the SpriteRenderer on the current GameObject
            SpriteRenderer spRend = gameObject.transform.GetComponent<SpriteRenderer>();
            // copy the SpriteRenderer's color property
            Color col = spRend.color;
            //  change col's alpha value (0 = invisible, 1 = fully opaque)
            col.a = 0.4f; // 0.5f = half transparent
                          // change the SpriteRenderer's color property to match the copy with the altered alpha value
            spRend.color = col;

        }
        else if (shieldPower == 3)
        {

            // store a reference to the SpriteRenderer on the current GameObject
            SpriteRenderer spRend = gameObject.transform.GetComponent<SpriteRenderer>();
            // copy the SpriteRenderer's color property
            Color col = spRend.color;
            //  change col's alpha value (0 = invisible, 1 = fully opaque)
            col.a = 0.6f; // 0.5f = half transparent
                          // change the SpriteRenderer's color property to match the copy with the altered alpha value
            spRend.color = col;

        }
        else if (shieldPower == 4)
        {

            // store a reference to the SpriteRenderer on the current GameObject
            SpriteRenderer spRend = gameObject.transform.GetComponent<SpriteRenderer>();
            // copy the SpriteRenderer's color property
            Color col = spRend.color;
            //  change col's alpha value (0 = invisible, 1 = fully opaque)
            col.a = 0.8f; // 0.5f = half transparent
                          // change the SpriteRenderer's color property to match the copy with the altered alpha value
            spRend.color = col;

        }
        else if (shieldPower == 5)
        {

            // store a reference to the SpriteRenderer on the current GameObject
            SpriteRenderer spRend = gameObject.transform.GetComponent<SpriteRenderer>();
            // copy the SpriteRenderer's color property
            Color col = spRend.color;
            //  change col's alpha value (0 = invisible, 1 = fully opaque)
            col.a = 1.0f; // 0.5f = half transparent
                          // change the SpriteRenderer's color property to match the copy with the altered alpha value
            spRend.color = col;

        }

    }

    //reduce one point from shield
    public void reduceShield()
    {
        shieldPower -= 1;

    }

}
