using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour {

    public Texture[] textures;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.D))
        {
            int AnimationFrame = -1;
            AnimationFrame = AnimationFrame + 1;
            GetComponent<Renderer>().material.mainTexture = textures[AnimationFrame];
        }
      


	}
}
