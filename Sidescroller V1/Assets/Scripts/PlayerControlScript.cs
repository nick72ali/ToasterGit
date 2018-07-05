using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {

    Rigidbody Player;
	// Use this for initialization
	void Start () {
        Player = GetComponent<Rigidbody>();
       
	}
	
	// Update is called once per frame
	void Update () {
        int PlayerSpeed = 5;
        //while A key is pressed
        if (Input.GetKey(KeyCode.A))
        {
            Player.velocity = new Vector3(-PlayerSpeed, 0, 0);
        }

        //while D key is pressed
        if (Input.GetKey(KeyCode.D))
        {
            Player.velocity = new Vector3(PlayerSpeed, 0, 0);
        }
	}
}
