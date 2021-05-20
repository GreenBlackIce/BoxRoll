using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.z < GameObject.Find("Main Camera").GetComponent<Camera>().transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
