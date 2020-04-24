using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oilSpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player1;
    public float spawnRate = 2;
    float nextSpawn = 0;

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;

            GameObject SpawnEnemy1 = Instantiate(enemy, this.transform.position, this.transform.rotation);

            enemy.GetComponent<EnemyScript>().player = player1.transform;
        }


    }
}
