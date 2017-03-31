using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    
    public int wave;
    int waveEnemies = 3; // enemies at the start of wave
    public int remainingEnemies = 1; // enemies remaining unspawned
    public int enemiesCurrently = 0; //enemies currently on stage
    int randomNro;
    public float spawnDelay;
    public bool startNextWave = true;

    public GameObject enemy1;

    public GameObject Spawner1;
    public GameObject Spawner2;
    public GameObject Spawner3;
    public GameObject Spawner4;
    public GameObject Spawner5;
    public GameObject Spawner6;
    public GameObject Spawner7;
    public GameObject Spawner8;

    // Use this for initialization
    void Start () {
        wave = 1;
	}
	void nextWave()
    { 
        wave++;
        print("Wave number "+wave);
        waveEnemies = wave * 3;
        remainingEnemies = waveEnemies;
    }
	// Update is called once per frame
	void Update ()
    {
        spawnDelay = spawnDelay - 0.1f;
        if ((spawnDelay < 0)&&(remainingEnemies>0))
        {
            randomNro = Random.Range(1, 9);
            enemiesCurrently++;
            remainingEnemies = remainingEnemies-1;
            if (randomNro == 1)
            {
                Instantiate(enemy1, new Vector2(Spawner1.transform.position.x, Spawner1.transform.position.y), Spawner1.transform.rotation);
            }
            else if (randomNro == 2)
            {
                Instantiate(enemy1, new Vector2(Spawner2.transform.position.x, Spawner2.transform.position.y), Spawner2.transform.rotation);
            }
            else if (randomNro == 3)
            {
                Instantiate(enemy1, new Vector2(Spawner3.transform.position.x, Spawner3.transform.position.y), Spawner3.transform.rotation);
            }
            else if (randomNro == 4)
            {
                Instantiate(enemy1, new Vector2(Spawner4.transform.position.x, Spawner4.transform.position.y), Spawner4.transform.rotation);
            }
            else if (randomNro == 5)
            { 
                Instantiate(enemy1, new Vector2(Spawner5.transform.position.x, Spawner5.transform.position.y), Spawner5.transform.rotation);
            }
            else if (randomNro == 6)
            {
                Instantiate(enemy1, new Vector2(Spawner6.transform.position.x, Spawner6.transform.position.y), Spawner6.transform.rotation);
            }
            else if (randomNro == 7)
            { 
                Instantiate(enemy1, new Vector2(Spawner7.transform.position.x, Spawner7.transform.position.y), Spawner7.transform.rotation);
            }
            else if (randomNro == 8)
            {
                Instantiate(enemy1, new Vector2(Spawner8.transform.position.x, Spawner8.transform.position.y), Spawner8.transform.rotation);
            }
        spawnDelay = 10;
        }
        if ((remainingEnemies <= 0)&&(enemiesCurrently <= 0))
        {
            if (startNextWave == true)
                nextWave();
        }
	}
    public void enemyDestroyed() {
        enemiesCurrently = enemiesCurrently - 1;
    }

    public void enemyAtBorder()
    {
        remainingEnemies++;
        enemiesCurrently = enemiesCurrently - 1;
    }

}
