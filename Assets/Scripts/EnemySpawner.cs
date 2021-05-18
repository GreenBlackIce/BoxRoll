using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public float spawnrate = 5f;

    public GameObject cubePrefab;
    public float playerMovmentSpeed = 5f;
    private float nextSpawnTime = 0f;
  
    void Start()
    {
        for(float i = 0f; i < 80f; i++)
        {
            GameObject cube = Instantiate(cubePrefab, Vector3.up * 2.8f + (Vector3.forward * (i + 10f)), Quaternion.identity);
            cube.transform.RotateAround(Vector3.zero, Vector3.back, Random.Range(0f, 360f));
        }
    }
    void Update()
    {
        if(Time.time >= nextSpawnTime)
        {
            GameObject cube = Instantiate(cubePrefab, (Vector3.up * 2.8f) + (Vector3.forward * 80) + (Vector3.forward * playerMovmentSpeed * nextSpawnTime), Quaternion.identity);
            cube.transform.RotateAround(Vector3.zero, Vector3.back, Random.Range(0f, 360f));

            nextSpawnTime = Time.time + 1f / spawnrate;
        }
    }
}
