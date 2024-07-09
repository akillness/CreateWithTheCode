using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals",startDelay, spawnInterval); 
        // Invokes the method methodName in time seconds, 
        // then repeatedly every repeatRate seconds.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        // Select type of GameObject ( Prefabs )
            int animalIndex = Random.Range(0,animalPrefabs.Length);

            if (animalIndex >= animalPrefabs.Length){
                animalIndex = animalPrefabs.Length-1;
            }else if (animalIndex < 0){
                animalIndex = 0;
            }

            Vector3 spwanPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);

            Instantiate(animalPrefabs[animalIndex],spwanPos,animalPrefabs[animalIndex].transform.rotation);
    }
}
