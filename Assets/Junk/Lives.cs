using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour {


    public int Life;
    public Ball ball;
    public Vector3 ballStart;
    public float respawnTimer;
    public float timer;
	// Use this for initialization
	void Start ()
    {
        ball = FindObjectOfType<Ball>();
        ballStart = ball.transform.position;
        timer = respawnTimer;
	}
	

    void ResetBall()
    {
        timer -= Time.deltaTime;
        ball.transform.position = ballStart;
        ball.rb.velocity = Vector3.zero;
        if(timer <= 0)
        {
            timer = respawnTimer;
            ball.isAlive = true;
        }
    }


	// Update is called once per frame
	void Update ()
    {
		if(!ball.isAlive)
        {
            ResetBall();
        }
	}
}
