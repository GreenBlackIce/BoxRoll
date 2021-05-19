using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovment : MonoBehaviour
{

    public float movmentSideSpeed = 100f;
    public float currentSideMovment = 0f;

    public float forwardMovmentspeedGrowth;

    public bool hasHitObject = false;
    // Update is called once per frame
    void Update()
    {
        currentSideMovment = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() 
    {
        transform.RotateAround(Vector3.zero, Vector3.back, movmentSideSpeed * currentSideMovment * Time.fixedDeltaTime);
        transform.position = transform.position + (Vector3.forward * forwardMovmentspeedGrowth * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collider) 
    {
        hasHitObject = true;
    }
}
