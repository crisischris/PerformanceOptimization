using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOff : MonoBehaviour {

    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Floor"))
        {

            gameObject.SetActive(false);
        }
    }
}
