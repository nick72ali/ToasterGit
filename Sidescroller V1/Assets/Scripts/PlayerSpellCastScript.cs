using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpellCastScript : MonoBehaviour {

    int AnimationFrame;

    public Texture[] PlayerSpellCastFramesRight;
    public Texture[] PlayerSpellCastUpFramesRight;


    //Calling Public variables from animation script
    public GameObject PlayerObject;
    private PlayerAnimationScript AnimationVariableAccess;
    private int PlayerSpellCastState;

    // Use this for initialization
    void Start () {

        AnimationVariableAccess = PlayerObject.GetComponent<PlayerAnimationScript>();
       

        InvokeRepeating("CastFireBallRight", 0, 0.125f);
        InvokeRepeating("CastFireBallUpRight", 0, 0.125f);
	}
	
    void CastFireBallRight()
    {
        PlayerSpellCastState = AnimationVariableAccess.PlayerSpellCastState;
        if (PlayerSpellCastState == 1)
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellCastFramesRight.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellCastFramesRight[AnimationFrame];
        }
    }

    void CastFireBallUpRight()
    {
        PlayerSpellCastState = AnimationVariableAccess.PlayerSpellCastState;
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
