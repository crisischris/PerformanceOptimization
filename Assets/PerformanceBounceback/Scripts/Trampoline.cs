using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    public ParticleSystem pSystem;
    public GameManager scoreScript;

	// Use this for initialization
	void Start () {

        scoreScript = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
	
	// Update is called once per frame
	void Update () {
       
       

	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            pSystem = GetComponentInChildren<ParticleSystem>();
            //Score Point
            scoreScript.score++;
            //Particle effect
            pSystem.Play();

            Debug.Log("Trampoline Hit");
        }

    }
}
