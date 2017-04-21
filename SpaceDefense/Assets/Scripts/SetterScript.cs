using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetterScript : MonoBehaviour {

    //Store variables that will alter the game somehow here.
    public float enemySpeed = 2;
    public int enemyLife = 2;

    public int waveNumber = 1;
    public int enemiesPerWave = 3;
    public float enemySpawnDelay = 2;

    /*
    GameObject Setter; 
    Setter = GameObject.Find("Setter");
    OtherVariable = Setter.GetComponent<SetterScript>().VariableFromThis;     
     */
}
