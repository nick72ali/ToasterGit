using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    //If the player is on the ground, it will assign a variable for use in the jump control
    public void OnCollisionEnter(Collision PlayerTouch)
    {

       int PlayerOnGround = 1;
        Debug.Log("Player is on ground");

    }
    public void OnCollisionExit(Collision PlayerTouch)
    {

        int PlayerOnGround = 0;
        Debug.Log("Player is off the ground");

    }

    // Update is called once per frame
    void Update () {
		
	}
}
