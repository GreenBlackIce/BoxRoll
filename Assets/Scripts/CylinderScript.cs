using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour
{
    public GameObject player;

    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 0, player.transform.position.z + 67f);
    }
}