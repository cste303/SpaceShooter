using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 2f;

    void Start()
    {
        // Invoke a method to spawn enemies at regular intervals
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Instantiate an enemy at the specified spawn point
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
}
