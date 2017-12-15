using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour {

    Lives lifeManager;


	// Use this for initialization
	void Start () {
        lifeManager = FindObjectOfType<Lives>();
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            lifeManager.Life--;
            lifeManager.ball.isAlive = false;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
