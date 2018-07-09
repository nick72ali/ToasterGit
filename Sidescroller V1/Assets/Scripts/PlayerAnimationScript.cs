using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour {

    Rigidbody rb;

    //Variable for changing animation frames
    int AnimationFrame;

    //Public variable for spell casting script
    public static int PlayerSpellCastState;

    //Public variables from other scripts
    static int PlayerOnGround;

    //Arrays where animation frames are stored
    public Texture[] PlayerWalkFrames;
    public Texture[] PlayerIdleFrames;
    public Texture[] PlayerJumpFrames;
    public Texture[] PlayerFallFrames;
    public Texture[] PlayerSpellChargeFrames;
   

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        PlayerOnGround = GroundScript.PlayerOnGround;

        //Timers for animation functions
        InvokeRepeating("MoveRight",0,0.125f);
        InvokeRepeating("Idle", 0, 0.125f);
        InvokeRepeating("Jump", 0, 0.125f);
        InvokeRepeating("Fall", 0, 0.125f);
        InvokeRepeating("SpellChain", 0, 0.125f);
        InvokeRepeating("SpellChain", 0, 0.125f);
        InvokeRepeating("SpellChain", 0, 0.125f);
        
  
    }
 
 

    void Idle()
    {
        if (!(Input.GetKey(KeyCode.D)))
        {
            if (!(Input.GetKey(KeyCode.A)))
            {
                if (!(Input.GetKey(KeyCode.W)))
                {
                    if (!(Input.GetKeyDown(KeyCode.W)))
                    {
                        AnimationFrame++;
                        AnimationFrame %= PlayerIdleFrames.Length;
                        GetComponent<Renderer>().material.mainTexture = PlayerIdleFrames[AnimationFrame];
                    }

                    
                }
            }
         
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

    void Jump()
    {
        
        if (Input.GetKey(KeyCode.W) || (Input.GetKeyDown(KeyCode.W)))
        {
            if (rb.velocity.y > 0.5f)
            {
                
                
                    AnimationFrame++;
                    AnimationFrame %= PlayerJumpFrames.Length;
                    GetComponent<Renderer>().material.mainTexture = PlayerJumpFrames[AnimationFrame];
                
           
            }
        
            

        }
    }
     void Fall()
    {   
        if (rb.velocity.y < 0)
        {
           
            
                AnimationFrame++;
                AnimationFrame %= PlayerFallFrames.Length;
                GetComponent<Renderer>().material.mainTexture = PlayerFallFrames[AnimationFrame];
            
     
        }
    }

    void SpellChain()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellChargeFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellChargeFrames[AnimationFrame];
            PlayerSpellCastState = 1;

            if ((Input.GetKey(KeyCode.D)))
            {
               // AnimationFrame++;
               // AnimationFrame %= PlayerSpellCastFrames.Length;
               // GetComponent<Renderer>().material.mainTexture = PlayerSpellCastFrames[AnimationFrame];
            }

            if ((Input.GetKey(KeyCode.W)))
            {
               // AnimationFrame++;
               // AnimationFrame %= PlayerSpellCastUpFrames.Length;
               // GetComponent<Renderer>().material.mainTexture = PlayerSpellCastUpFrames[AnimationFrame];
            }
        }
    }

  
   
    // Update is called once per frame
    void Update () {
        Debug.Log("Player velocity is" + rb.velocity.y);
	}
}
