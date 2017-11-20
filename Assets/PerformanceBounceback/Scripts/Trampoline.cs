using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    public ParticleSystem pSystem;
    public GameManager scoreScript;
    public Score score;

	// Use this for initialization
	void Start () {

        scoreScript = GameObject.Find("GameManager").GetComponent<GameManager>();

        score = GameObject.FindGameObjectWithTag("ScoreKeep").GetComponent<Score>();
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
            score.pointScored();
            //Particle effect
            pSystem.Play();

        }

    }
}
