using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour {

    //Creates variable "rb" for storage of the rigidbody
    Rigidbody rb;

    //Variable for changing animation frames
    int AnimationFrame;

    //Variable for player direction
    int PlayerDirection = 1;


    //Public variables from other scripts
    static int PlayerOnGround;


    //Arrays where animation frames are stored
    public Texture[] PlayerWalkFrames;
    public Texture[] PlayerIdleFrames;
    public Texture[] PlayerJumpFrames;
    public Texture[] PlayerFallFrames;
 
   

	// Use this for initialization
	void Start () {
        
        //Sets empty variable "rb" to the rigidbody of this gameobject
        rb = GetComponent<Rigidbody>();
 


        //Timers for animation functions
        InvokeRepeating("MoveRight",0,0.125f);
        InvokeRepeating("Idle", 0, 0.125f);
        InvokeRepeating("Jump", 0, 0.125f);
        InvokeRepeating("Fall", 0, 0.125f);
        InvokeRepeating("FallFix", 0, 0.125f);
         
         
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

    void FallFix()
    {
        if (PlayerOnGround == 1 && (Input.GetKey(KeyCode.W) && !(Input.GetKey(KeyCode.D))))
        {
            AnimationFrame++;
            AnimationFrame %= PlayerFallFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerIdleFrames[AnimationFrame];
        }

    }

    // Update is called once per frame
    void Update () {

        Debug.Log(PlayerOnGround);
        PlayerOnGround = GroundScript.PlayerOnGround;

    }
}
