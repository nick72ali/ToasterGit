using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelScript : MonoBehaviour {


    public Transform WaterTarget;

    public float smoothSpeed = 0.125f;
    
    void FixedUpdate()
    {
        Vector3 desiredPosition = WaterTarget.position;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        
    }

}
