using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelScript : MonoBehaviour {


    public Transform WaterTarget;

    public float smoothSpeed = 0.125f;

    private void Start()
    {
        InvokeRepeating("MoveWater", 0, 0.05f);
    }
    void MoveWater()
    {
        Vector3 desiredPosition = WaterTarget.position;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

    }

    void FixedUpdate()
    {
 
        
    }

}
