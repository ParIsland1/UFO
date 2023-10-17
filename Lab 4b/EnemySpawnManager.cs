using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs;
    private float spawnRangeX = 20f;
    private float spawnInterval = 1.5f;
    private float startDelay = 2f;
    private float spawnPosZ = 20f;

    private void Start()
    {
        // Start spawning UFOs at regular intervals
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    private void SpawnRandomUFO()
    {
        // Generate a random position for the UFO
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(0, spawnPosZ));

        // Choose a random UFO prefab to spawn
        int ufoIndex = Random.Range(0, ufoPrefabs.Length);

        // Instantiate the selected UFO at the generated position
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
    }
}

