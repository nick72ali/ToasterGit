using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour {

    Rigidbody rb;


    int AnimationFrame;

    static int PlayerState;
    static int PlayerOnGround;

    public Texture[] PlayerWalkFrames;
    public Texture[] PlayerIdleFrames;
    public Texture[] PlayerJumpFrames;
    public Texture[] PlayerFallFrames;
    public Texture[] PlayerSpellChargeFrames;
    public Texture[] PlayerSpellCastFrames;
    public Texture[] PlayerSpellCastUpFrames;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        PlayerState = PlayerControlScript.PlayerState;
        PlayerOnGround = GroundScript.PlayerOnGround;
        InvokeRepeating("MoveRight",0,0.125f);
        InvokeRepeating("Idle", 0, 0.125f);
        InvokeRepeating("Jump", 0, 0.125f);
        InvokeRepeating("Fall", 0, 0.125f);
        InvokeRepeating("SpellCharge", 0, 0.125f);
        InvokeRepeating("SpellCast", 0, 0.125f);
        InvokeRepeating("SpellCastUp", 0, 0.125f);
  
    }

 void Idle()
    {
        if (!(Input.GetKey(KeyCode.D) && !(Input.GetKey(KeyCode.W) && !(Input.GetKey(KeyCode.A) && !(Input.GetKeyDown(KeyCode.W))))))
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

    void Jump()
    {
        
        if (Input.GetKey(KeyCode.W) || (Input.GetKeyDown(KeyCode.W)))
        {
            AnimationFrame++;
            AnimationFrame %= PlayerJumpFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerJumpFrames[AnimationFrame];
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

    void SpellCharge()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellChargeFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellChargeFrames[AnimationFrame];
        }
    }

    void SpellCast()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.D)))
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellCastFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellCastFrames[AnimationFrame];
        }
    }

    void SpellCastUp()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W)))
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellCastUpFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellCastUpFrames[AnimationFrame];
        }
    }
    // Update is called once per frame
    void Update () {

	}
}
