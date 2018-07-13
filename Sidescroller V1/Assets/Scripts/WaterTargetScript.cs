using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTargetScript : MonoBehaviour {



    void WaterUp()
    {
        transform.position = new Vector3(0, 0.2f, 0);

    }

    void WaterDown()
    {
        transform.position = new Vector3(0, 0, 0);
    }
}
