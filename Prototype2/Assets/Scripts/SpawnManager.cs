using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// used to manage animal prefabs
public class SpawnManager : MonoBehaviour
{
    // array for prefabs
    public GameObject[] animalPrefabs;

    // x position for prefabs. we use this in range
    private float spawnRangeX = 15f;

    // z position for prefabs
    private float spawnPosZ = 20f;

    private float startDelay = 2f; // start after startDelay seconds
    private float spawnInterval = 1.5f; // prefab creation interval
    // Start is called before the first frame update
    void Start()
    {
        // execute the displayed function at the specified interval
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        //position for prefabs
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // animal index for random
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // clone a prefabs
        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }

}
