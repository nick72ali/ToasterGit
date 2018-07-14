using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerSpellCastScript : MonoBehaviour {

    int AnimationFrame;

    public Texture[] PlayerSpellCastFramesRight;
    public Texture[] PlayerSpellCastUpFramesRight;
    public Texture[] PlayerSpellChargeFrames;

    //Calling Public variables from animation script
    public int PlayerSpellCastState;
    
    // Use this for initialization
    void Start () {


	}


    void SpellChain()
    {
       
        if (Input.GetKey(KeyCode.LeftShift))
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellChargeFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellChargeFrames[AnimationFrame];


            if ((Input.GetKey(KeyCode.D)))
            {
                if (Input.GetKeyUp(KeyCode.LeftShift) && (Input.GetKeyUp(KeyCode.D)))
                {
                    InvokeRepeating("CastFireBallRight", 0, 0.125f);
                }

            }

            if ((Input.GetKeyDown(KeyCode.W)))
            {
                if (Input.GetKeyUp(KeyCode.LeftShift) && (Input.GetKeyUp(KeyCode.W)))
                {
                    InvokeRepeating("CastFireBallUpRight", 0, 0.125f);
                }
            }
        }
    }

    void CastFireBallRight()
    {


        AnimationFrame++;
        AnimationFrame %= PlayerSpellCastFramesRight.Length;
        GetComponent<Renderer>().material.mainTexture = PlayerSpellCastFramesRight[AnimationFrame];


    }

    void CastFireBallUpRight()
    {

        AnimationFrame++;
        AnimationFrame %= PlayerSpellCastUpFramesRight.Length;
        GetComponent<Renderer>().material.mainTexture = PlayerSpellCastUpFramesRight[AnimationFrame];

    }
	// Update is called once per frame
	void Update () {
      







	}
}
