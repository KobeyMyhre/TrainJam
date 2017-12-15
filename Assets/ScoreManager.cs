using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public  class ScoreManager : MonoBehaviour {

    Text scoreText;
    public int score;

   


	// Use this for initialization
	void Start ()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
	}
	

    public void UpdateScore(int scoreAdded)
    {
        score += scoreAdded;
        scoreText.text = score.ToString();
    }

	// Update is called once per frame
	void Update ()
    {
		
	}
}
