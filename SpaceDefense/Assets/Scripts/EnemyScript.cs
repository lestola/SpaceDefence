using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public float speed; // speed at which enemy moves
    public float rateOfFire; // speed at which enemy shoots
    public int life; // enemy life
    public int EnemyNo; //which enemy type
    public Rigidbody2D rb; //rigidbody
    bool hasShot; // need to check to make sure doesn't shoot more than once

    public GameObject EnemyProjectile;
    public GameObject leftBeam;
    public GameObject rightBeam;
    GameObject Spawner;
    GameObject Player1;


    // Use this for initialization
    void Start () {
        hasShot = false;
        rb = GetComponent<Rigidbody2D>();
        Spawner = GameObject.Find("Spawner"); //find spawner script
        Player1 = GameObject.Find("Player"); //find spawner script
        if (EnemyNo == 1)
        {
            rateOfFire = 5;
            life = 1;
            rb.AddForce((transform.up * speed), ForceMode2D.Impulse); //add force to object to make it fly forward
        }
    }

    //turhaa koska tapahtuu jo toisessa skriptissä
    /*void Update ()
    {
        if (Vector2.Distance(Player1.transform.position, transform.position) > 5)
        {
            rightBeam.gameObject.SetActive(false);
            leftBeam.gameObject.SetActive(false);
        }
        else if ((hasShot == false) && (Vector2.Distance(Player1.transform.position, transform.position) < 5)) //if distance to player is less than X, make laser visible and damage player
        {
            rightBeam.gameObject.SetActive(true);
            leftBeam.gameObject.SetActive(true);
            hasShot = true;
        }
    }*/

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Border")
        {
            //find spawner and activate a function which adds to its enemy counter, then remove this
            Spawner.gameObject.GetComponent<EnemySpawner>().enemyAtBorder();
            Destroy(gameObject);
        }
    }

    public void takeDamage() {
        life = life - 1;
        if (life < 1)
        {
            death();
        }
    }
    public void death()
    {
        Spawner.gameObject.GetComponent<EnemySpawner>().enemyDestroyed();
        Destroy(gameObject);
    }
}
