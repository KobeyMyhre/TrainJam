using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour {

    ParticleSystem explosion;
    public GameObject FX;

	// Use this for initialization
	void Start () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            var spawn = Instantiate(FX);
            Destroy(FX, 2);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
