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
        InvokeRepeating("CastFireBallUpRight", 0, 0.125f);
        InvokeRepeating("ResetState", 0, 0.125f);
      
	}

    void ResetState()
    {
        PlayerSpellCastState = 0;
    }

    void SpellChain()
    {
       
        if (Input.GetKey(KeyCode.LeftShift))
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellChargeFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellChargeFrames[AnimationFrame];


            if ((Input.GetKeyDown(KeyCode.D)))
            {
                AnimationFrame++;
                AnimationFrame %= PlayerSpellCastFramesRight.Length;
                GetComponent<Renderer>().material.mainTexture = PlayerSpellCastFramesRight[AnimationFrame];
            }

            if ((Input.GetKeyDown(KeyCode.W)))
            {
                PlayerSpellCastState = 2;
            }
        }
    }

    void CastFireBallRight()
    {
        
        if (PlayerSpellCastState == 1)
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellCastFramesRight.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellCastFramesRight[AnimationFrame];
        }
    }

    void CastFireBallUpRight()
    {
       
        if (PlayerSpellCastState == 2)
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellCastUpFramesRight.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellCastUpFramesRight[AnimationFrame];
        }
    }
	// Update is called once per frame
	void Update () {
        Debug.Log("SpellCast State is" + PlayerSpellCastState);
	}
}
