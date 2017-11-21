﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    public ParticleSystem pSystem;
    public GameManager scoreScript;
    public Score score;

	
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            //Score Point
            GameManager.score++;
            score.ChangeScoreUI();
            //Particle effect
            pSystem.Play();

        }

    }
}
