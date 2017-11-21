using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    public Text text;
    public int oldScore;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
        if(GameManager.score != oldScore)
        {
            ChangeScoreUI();
        }

	}

    public void ChangeScoreUI()
    {
        text.text = "Score: " + GameManager.score.ToString();
    }
}
