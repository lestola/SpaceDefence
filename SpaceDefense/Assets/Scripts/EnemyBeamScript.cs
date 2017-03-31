using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeamScript : MonoBehaviour
{
    float timer = 0;
    SpriteRenderer sr;
    public bool IsShooting = false;

    // Use this for initialization
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (IsShooting == true)
        {
            timer = timer + 1* Time.deltaTime;
        }
        if (timer > 1)
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
        if (other.gameObject.tag == "Player")
        {
            IsShooting = true;
        }
    }
}
