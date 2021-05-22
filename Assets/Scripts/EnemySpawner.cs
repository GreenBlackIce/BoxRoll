using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public float spawnrate = 5f;

    public GameObject ringPrefab;
    public float playerMovmentSpeed = 5f;
    private float nextSpawnTime = 0f;

    private float randomFloat = -1f;
  
    void Start()
    {
        for(float i = 0f; i < 15f; i++)
        {
            GameObject ring = Instantiate(ringPrefab,Vector3.forward * (( i* 10) + 20f), Quaternion.identity);
            if(randomFloat == -1f)
            {
                randomFloat = Random.Range(-45f, 45f);
            }
            else
            {
                randomFloat = Random.Range(randomFloat - 90f, randomFloat + 90f);
            }

            ring.transform.RotateAround(Vector3.zero, Vector3.back, randomFloat);

        }
        nextSpawnTime = 0f;
    }
    void Update()
    {
        float adjustedTimeSinceLevelLoad = Time.timeSinceLevelLoad - 2.8f;
        if(adjustedTimeSinceLevelLoad >= nextSpawnTime)
        {
            GameObject ring = Instantiate(ringPrefab, (Vector3.forward * 170f) + (Vector3.forward * playerMovmentSpeed * nextSpawnTime * 1.90f), Quaternion.identity);
            randomFloat = Random.Range(randomFloat - 90f, randomFloat + 90f);
            ring.transform.RotateAround(Vector3.zero, Vector3.back, randomFloat);
            nextSpawnTime = adjustedTimeSinceLevelLoad + 6f / spawnrate;
        }
    }
}
