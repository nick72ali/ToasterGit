using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpellCastScript : MonoBehaviour {

    int AnimationFrame;

    public Texture[] PlayerSpellCastFrames;
    public Texture[] PlayerSpellCastUpFrames;

    static int PlayerSpellCastState;

    // Use this for initialization
    void Start () {
        PlayerSpellCastState = PlayerAnimationScript.PlayerSpellCastState;
        InvokeRepeating("CastFireBallRight", 0, 0.125f);
        InvokeRepeating("CastFireBallUpRight", 0, 0.125f);
	}
	
    void CastFireBallRight()
    {
        if (PlayerSpellCastState == 1)
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellCastFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellCastFrames[AnimationFrame];
        }
    }

    void CastFireBallUpRight()
    {
        if (PlayerSpellCastState == 2)
        {
            AnimationFrame++;
            AnimationFrame %= PlayerSpellCastUpFrames.Length;
            GetComponent<Renderer>().material.mainTexture = PlayerSpellCastUpFrames[AnimationFrame];
        }
    }
	// Update is called once per frame
	void Update () {
        Debug.Log("SpellCast State is" + PlayerSpellCastState);
	}
}
