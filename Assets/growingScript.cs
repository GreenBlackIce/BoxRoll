using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growingScript : MonoBehaviour
{
    public float growRate = 5f;

    private float nextGrowTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextGrowTime)
        {
            transform.localScale += (Vector3.up * (growRate/2f) * Time.deltaTime);
            transform.position += (Vector3.forward * (growRate/2f) * Time.deltaTime);
        }
    }
}
