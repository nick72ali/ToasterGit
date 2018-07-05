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

        //Set Player's speed and jump height
        float PlayerSpeed = 0.05f;
        float PlayerJumpHt = 5;

        //while A key is pressed, move left
        if (Input.GetKey(KeyCode.A))
        {
          
            PlayerPos = transform.position;
            PlayerPos.x -= PlayerSpeed;
            transform.position = PlayerPos;
            Debug.Log("Player moving left");

        }
        //while D key is pressed, move right
        if (Input.GetKey(KeyCode.D))
        {
            
            PlayerPos = transform.position;
            PlayerPos.x += PlayerSpeed;
            transform.position = PlayerPos;
            Debug.Log("Player moving right");

        }
        //while W key is pressed and player is on the ground, jump
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            Debug.Log("Player jumping");

        }
	}
}
