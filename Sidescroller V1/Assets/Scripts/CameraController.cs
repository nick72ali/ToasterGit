using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Script is used to keep camera focused on the player
public class CameraController : MonoBehaviour {


    public GameObject Player;
    Vector3 Offset;
	
	// Update is called once per frame
	void Update () {

        Offset = transform.position - Player.transform.position;
        
	}

    private void LateUpdate()
    {
        transform.position = Player.transform.position + Offset;
    }
}*/

//Learned With Brackeys Video
public class CameraController : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed*Time.deltaTime);
        transform.position = smoothedPosition;

        //transform.LookAt(target);
    }

}
