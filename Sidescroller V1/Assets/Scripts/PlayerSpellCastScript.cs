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
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("SpellCast State is" + PlayerSpellCastState);
	}
}
