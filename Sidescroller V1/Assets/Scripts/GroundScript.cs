using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script detects if player is on the ground, sets a public variable to store the information
public class GroundScript : MonoBehaviour {

    //Declare variable for ground state
    public static int PlayerOnGround;

    //Depending on player position relative to the ground, it will assign a value to the ground state variable
    public void OnCollisionEnter(Collision PlayerTouch)
    {

       PlayerOnGround = 1;
        Debug.Log("Player is on ground");
      
    }
    public void OnCollisionExit(Collision PlayerTouch)
    {

        PlayerOnGround = 0;
        Debug.Log("Player is off the ground");
      
    }
}
