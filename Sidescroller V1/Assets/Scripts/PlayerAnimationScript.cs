using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour {

    int AnimationFrame;
    public Texture[] PlayerWalkFrames;
	// Use this for initialization
	void Start () {

        InvokeRepeating("MoveRight",0,0.125f);

  
    }

    void MoveRight()
    {
        if (Input.GetKey(KeyCode.D))
        {

            AnimationFrame++;
            AnimationFrame %= PlayerWalkFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerWalkFrames[AnimationFrame];
        }


    }

    // Update is called once per frame
    void Update () {

	}
}
