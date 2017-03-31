using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LasProjectile : MonoBehaviour {

    public float speed = 10;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce((transform.up * speed), ForceMode2D.Impulse);
        //sound effects when fired
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        //sound effect, cause damage function 
        if (other.gameObject.tag == "Enemy")
        { 
            other.gameObject.GetComponent<EnemyScript>().takeDamage();
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
