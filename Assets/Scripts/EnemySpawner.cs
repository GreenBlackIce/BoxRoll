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
            GameObject ring = Instantiate(ringPrefab,Vector3.forward * (( i* 10) + 10f), Quaternion.identity);
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
    }
    void Update()
    {
        if(Time.time >= nextSpawnTime)
        {
            GameObject ring = Instantiate(ringPrefab, (Vector3.forward * 160f) + (Vector3.forward * playerMovmentSpeed * nextSpawnTime), Quaternion.identity);
            randomFloat = Random.Range(randomFloat - 90f, randomFloat + 90f);
            ring.transform.RotateAround(Vector3.zero, Vector3.back, randomFloat);
            nextSpawnTime = Time.time + 13f / spawnrate;
        }
    }
}
