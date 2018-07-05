using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {

    Vector3 PlayerPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //while A key is pressed
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPos = transform.position;
            PlayerPos.x -= 0.5f;
            transform.position = PlayerPos;
        }

        //while D key is pressed
        if (Input.GetKeyDown(KeyCode.D))
        {
            PlayerPos = transform.position;
            PlayerPos.x += 0.5f;
            transform.position = PlayerPos;
        }
	}
}
