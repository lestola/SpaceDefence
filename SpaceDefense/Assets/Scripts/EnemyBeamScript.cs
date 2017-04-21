using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeamScript : MonoBehaviour
{
    float timer = 0;
    SpriteRenderer sr;

    bool IsShooting = false;
    bool hasShot = false;

    // turhia
    int Zhelp;
    float zAkseli;

    // Use this for initialization
    void Start()
    {
        IsShooting = false;
        hasShot = false;
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (IsShooting == true)
        {
            timer = timer + 1* Time.deltaTime;
        }
        if (timer > 20.5)
        {
            IsShooting = false;
        }
        if (IsShooting == true)
            sr.enabled = true;
        else
            sr.enabled = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "Player")&&(hasShot == false))
        {
            IsShooting = true;
            hasShot = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsShooting = false;
        }
    }

    void StartTurning() //ei toimi 
    {
        Zhelp=Zhelp+2;
        if(gameObject.name == "LeftBeam")
        { 
            zAkseli = 1*Zhelp;
        }
        else if (gameObject.name == "RightBeam") // +X -Y
        { 
            zAkseli = transform.rotation.z - 1 * Zhelp;
            transform.localPosition = new Vector3(transform.localPosition.x+0.1f, transform.localPosition.y-0.1f, transform.localPosition.z);
        }
        transform.rotation = Quaternion.Euler(0, 0, zAkseli);
    }
}
