using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {

   //Empty variable for vector 3 to use later
    Vector3 PlayerPos;

    //Create variable to recieve public variable from GroundScript
    static int PlayerOnGround;

	// Use this for initialization
	void Start () {
        
      
	}

	// Update is called once per frame
	void Update () {

        //Assign public variable to empty variable created earlier
        PlayerOnGround = GroundScript.PlayerOnGround;

        //Allow script access to rigidbody
        Rigidbody rb;

        //Set Player's speed and jump height
        float PlayerSpeed = 0.02f;
        float PlayerJumpForce = 5;

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
        if (Input.GetKeyDown(KeyCode.W) && (PlayerOnGround == 1))
        {
            
            //The player's jump uses unity physics
            rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, PlayerJumpForce, 0);
            Debug.Log("Player jumping");
       
        }
	}
}
