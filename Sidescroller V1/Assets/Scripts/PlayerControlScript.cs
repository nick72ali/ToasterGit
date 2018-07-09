using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script dictates player character controls
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

        //Allow update function access to rigidbody
        Rigidbody rb;

        //Set Player's speed and jump height
        float PlayerSpeed = 0.04f;
        float PlayerJumpForce = 7;

      

        //while A key is pressed, move left
        if (Input.GetKey(KeyCode.A)&& !(Input.GetKey(KeyCode.LeftShift)))
        {
          
          
            
            PlayerPos = transform.position;
            PlayerPos.x -= PlayerSpeed;
            transform.position = PlayerPos;
            Debug.Log("Player moving left");
            
       


        }
        //while D key is pressed, move right
        if (Input.GetKey(KeyCode.D)&& !(Input.GetKey(KeyCode.LeftShift)))
        {
            
          
            
            PlayerPos = transform.position;
            PlayerPos.x += PlayerSpeed;
            transform.position = PlayerPos;
            Debug.Log("Player moving right");
            


        }
        //while W key is pressed and player is on the ground, jump
        if (Input.GetKeyDown(KeyCode.W) && (PlayerOnGround == 1) && !(Input.GetKey(KeyCode.LeftShift)))
        {
            
            //The player's jump uses unity physics
            rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, PlayerJumpForce, 0);
            Debug.Log("Player jumping");
       
        }
      
        
	}
    private void FixedUpdate()
    {
        //Allows fixedupdate function access to rigidbody, sets variable for rigidbody to be assigned to
        Rigidbody rb;
        rb = GetComponent<Rigidbody>();

        //Sets multiplers to player's jump, allows for variable jump gravity
        float PlayerFallMult = 4f;
        float PlayerLowJumpMult = 4f;

        //Applies gravity multiplier for when player is falling
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (PlayerFallMult - 1) * Time.fixedDeltaTime;
         

        }

        //Applies multiplier for a lower jump by tapping the jump key
        else if ((rb.velocity.y > 0) && !(Input.GetKey(KeyCode.W) && !(Input.GetKey(KeyCode.LeftShift))))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (PlayerLowJumpMult - 1) * Time.fixedDeltaTime;
        }
    }

}
