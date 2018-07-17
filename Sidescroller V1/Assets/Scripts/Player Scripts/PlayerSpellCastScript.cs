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
       InvokeRepeating("SpellChain", 0, 0.125f);
       InvokeRepeating("CastFireBallRight", 0, 0.125f);
    }


    void SpellChain()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {

            AnimationFrame++;
            AnimationFrame %= PlayerSpellChargeFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellChargeFrames[AnimationFrame];


            if (Input.GetKeyUp(KeyCode.W))
            {

                AnimationFrame++;
                AnimationFrame %= PlayerSpellCastUpFramesRight.Length;
                GetComponent<Renderer>().material.mainTexture = PlayerSpellCastUpFramesRight[AnimationFrame];

            }


        }

    }

    void CastFireBallRight()
    {

        if (Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.LeftShift)))
        {

            AnimationFrame++;
            AnimationFrame %= PlayerSpellCastFramesRight.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellCastFramesRight[AnimationFrame];

            if (AnimationFrame == 3)
            {
                CancelInvoke("CastFireBallRight");
            }

        }

    }

    void CastFireBallUpRight()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

        }
    }
	// Update is called once per frame
	void Update () {






    }
}
