using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] collectiblePrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2; 
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCollectible", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomCollectible()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int collectibleIndex = Random.Range(0, collectiblePrefabs.Length);
        Instantiate(collectiblePrefabs[collectibleIndex], spawnPos, collectiblePrefabs[collectibleIndex].transform.rotation);
       
        Vector3 spawnDown = new Vector3(-3, 6, 18);
        Instantiate(collectiblePrefabs[collectibleIndex], spawnDown, collectiblePrefabs[collectibleIndex].transform.rotation);

    }
}
