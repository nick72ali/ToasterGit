using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour {

    int AnimationFrame;
    int PlayerState;
    public Texture[] PlayerWalkFrames;
    public Texture[] PlayerIdleFrames;

	// Use this for initialization
	void Start () {

        PlayerState = PlayerControlScript.PlayerState;
        InvokeRepeating("MoveRight",0,0.125f);
        InvokeRepeating("Idle", 0, 0.125f);
  
    }

 void Idle()
    {
        if (!(Input.GetKey(KeyCode.D)))
        {
            AnimationFrame++;
            AnimationFrame %= PlayerIdleFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerIdleFrames[AnimationFrame];
        }

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
