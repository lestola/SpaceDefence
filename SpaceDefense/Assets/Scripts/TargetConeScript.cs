using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetConeScript : MonoBehaviour {

    public GameObject Targeted1;
    GameObject Targeted2;
    GameObject Targeted3;
    public List<GameObject> EnemyPriority = new List<GameObject>();
    public GameObject ConeGO;
    public GameObject TurretGO;

    //needed for lookat2D
    Vector3 direction;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Mouse0)) // when click, turn cone towards mouse
        {
            direction = Input.mousePosition - new Vector3(Screen.width / 2 + TurretGO.transform.position.x, Screen.height / 2 + TurretGO.transform.position.y);
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 270;
            ConeGO.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        //Targeted1 = EnemyPriority[0];
       
       /* for (int i=0; i<=EnemyPriority.Capacity; i++)
        {
            if (EnemyPriority[i] == null)
            { 
                EnemyPriority[i] = EnemyPriority[1+i];
                
            }
        }*/
    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy" )
        {
            EnemyPriority.Add(other.gameObject);
        }
    }*/

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Targeted1 = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Targeted1 = null;
        /*if (other.tag == "Enemy")
        {
            if(EnemyPriority[EnemyPriority.Capacity] == null)
            {
                EnemyPriority.RemoveAt(EnemyPriority.Capacity);
            }
        }*/
    }
    /*void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Targeted1 = null;
            /*for (int i = 0; i <= EnemyPriority.Capacity; i++)
            {
                if (EnemyPriority[i] == other.gameObject)
                {
                    EnemyPriority.RemoveAt(i);
                    
                }
            }
        }
        if (other.tag == "Enemy")
        { 
            for (int i = 0; i < enemies.Capacity; i++) //do to every item in enemies
            {
                bool t = false; // create new bool for checks
                if (t) //this object has been found
                {
                    if (i <= enemies.Capacity - 1) // before last item in enemies
                    {
                        enemies[i] = enemies[i + 1]; // overwrite current item with next one
                    }
                    else
                    {
                        enemies.RemoveAt(i); // at final item, remove item
                    }
                }
                if (enemies[i] == other)
                {
                    t = true; //if this object has been found
                }
            }
        }

       
        if (other.gameObject == Targeted1)
        {
            Targeted1 = null;
            if (Targeted2 != null)
            { 
                Targeted1 = Targeted2;
                Targeted2 = Targeted3;
                Targeted3 = null;
            }
        }
        else if (other.gameObject == Targeted2)
        {
            Targeted2 = null;
            if (Targeted3 != null)
            {
                Targeted2 = Targeted3;
                Targeted3 = null;
            }
        }
        else if (other.gameObject == Targeted3)
        {
            Targeted3 = null;
        }/
    }//*/
}
