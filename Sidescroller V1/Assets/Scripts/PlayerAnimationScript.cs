using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour {

    public GameObject PlayerIdle;
    public GameObject PlayerWalk;
    public GameObject PlayerSpellCast;
    public GameObject PlayerSpellCharge;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      

            PlayerIdle.SetActive(true);
            PlayerWalk.SetActive(false);
            PlayerSpellCast.SetActive(false);
            PlayerSpellCharge.SetActive(false);
        
		
        if (Input.GetKey(KeyCode.D))
        {
            PlayerIdle.SetActive(false);
            PlayerWalk.SetActive(true);
            PlayerSpellCast.SetActive(false);
            PlayerSpellCharge.SetActive(false);

        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            PlayerIdle.SetActive(false);
            PlayerWalk.SetActive(false);
            PlayerSpellCast.SetActive(false);
            PlayerSpellCharge.SetActive(true);
        }
	}
}
