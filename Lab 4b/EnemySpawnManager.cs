using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    public int ufoIndex;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }
    void Update()
    {
        
    }
    void SpawnRandomUFO()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
           Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
           int ufoIndex = Random.Range(0, ufoPrefabs.Length);
           Instantiate(ufoPrefabs[ufoIndex], new Vector3(0, 0, 20), ufoPrefabs[ufoIndex].transform.rotation);
        }
            
    }
}
