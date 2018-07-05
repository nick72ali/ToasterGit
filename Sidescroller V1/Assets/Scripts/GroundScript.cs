using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

    //Declare variable for ground state
    public static int PlayerOnGround = 0;

    //Depending on player position relative to the ground, it will assign a value to the ground state variable
    public void OnCollisionEnter(Collision PlayerTouch)
    {

       PlayerOnGround = 1;
        Debug.Log("Player is on ground");
      
    }
    public void OnCollisionExit(Collision PlayerTouch)
    {

        PlayerOnGround = 2;
        Debug.Log("Player is off the ground");
      
    }
}
