using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script is used to keep camera focused on the player
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
}
