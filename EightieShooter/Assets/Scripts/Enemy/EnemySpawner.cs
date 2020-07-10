using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnRate;
    [SerializeField] Transform[] spawnPoints;

    //Spawn enemies every second on random spawnpoint;
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, spawnRate);
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
    }


    public void StopSpawning()
    {
        CancelInvoke();
    }

}
