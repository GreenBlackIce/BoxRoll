using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour
{
    public GameObject player;

    
    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad >= 3f)
        {
            transform.position = new Vector3(0, 0, player.transform.position.z + 67f);
        }
    }
}
