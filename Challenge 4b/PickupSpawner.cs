using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawnManager : MonoBehaviour
{
    public GameObject[] pickups;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    public int ufoIndex;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnPickups", startDelay, spawnInterval);
    }
    void Update()
    {
        
    }
    void SpawnPickups()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
           Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
           int pickupIndex = Random.Range(0, pickups.Length);
           Instantiate(ufoPrefabs[ufoIndex], new Vector3(0, 0, 20), pickups[pickupIndex].transform.rotation);
        }
            
    }
}
