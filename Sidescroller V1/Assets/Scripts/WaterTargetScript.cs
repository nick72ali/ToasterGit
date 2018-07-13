using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTargetScript : MonoBehaviour {

    private void Start()
    {
        InvokeRepeating("WaterUp", 0, 10);
        InvokeRepeating("WaterDown", 0, 15);
    }

    void WaterUp()
    {
        transform.position = new Vector3(0, 0.06f, 0);

    }

    void WaterDown()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}
