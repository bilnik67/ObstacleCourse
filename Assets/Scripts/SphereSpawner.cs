using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public GameObject spherePrefab; 
    public float spawnInterval = 5f;
    

    // Positions on the ramp where the sphere needs to spawn.
    private Vector3 startPosition = new Vector3(55f, 25f, 2.06999993f);
    private Vector3 endPosition = new Vector3(55f, 25f, 14f);
    private float timer;

    private void Start()
    {
        timer = spawnInterval; 
    }

    private void Update()
    {
        timer -= Time.deltaTime; 

        if (timer <= 0)
        {
            SpawnSphere();
            timer = spawnInterval; 
        }
    }

    void SpawnSphere()
    {
        float lerpFactor = Random.Range(0f, 1f); 
        Vector3 spawnPosition = Vector3.Lerp(startPosition, endPosition, lerpFactor); 
        GameObject sphere = Instantiate(spherePrefab, spawnPosition, Quaternion.identity);
        Destroy(sphere, 10f); 
    }
}
