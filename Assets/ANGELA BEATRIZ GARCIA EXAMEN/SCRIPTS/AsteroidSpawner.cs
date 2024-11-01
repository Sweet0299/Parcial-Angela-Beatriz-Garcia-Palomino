using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AsteroidSpawner : MonoBehaviour
{

    public float minimumSpawnTime;
    public float maximumSpawnTime;
    public GameObject prefab;


    private float minX = -5f; 
    private float maxX = 5f;  
    private float fixedY = 1f;
    private float fixedZ = 20f;



    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
       
            Vector3 spawnPosition = RandomSpawnPosition();
            Debug.Log("Generated Spawn Position: " + spawnPosition);

           
            GameObject spawnedObject = Instantiate(prefab);

           
            spawnedObject.transform.position = new Vector3(
                Mathf.Clamp(spawnPosition.x, minX, maxX),
                fixedY,
                fixedZ
            );


           
            yield return new WaitForSeconds(SpawnTime());
        }
    }

    private Vector3 RandomSpawnPosition()
    {
       
        float randomX = Random.Range(minX, maxX);
        return new Vector3(randomX, fixedY, fixedZ);
    }

    private float SpawnTime()
    {
        return Random.Range(minimumSpawnTime, maximumSpawnTime);
    }




}
